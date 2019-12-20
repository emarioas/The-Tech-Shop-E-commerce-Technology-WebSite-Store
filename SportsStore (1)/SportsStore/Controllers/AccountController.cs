using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SportsStore.Controllers {

    public class AccountController : Controller {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userMgr,
                               SignInManager<IdentityUser> signInMgr) {
            userManager = userMgr;
            signInManager = signInMgr;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl) {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel creds, 
                string returnUrl) {

            if (ModelState.IsValid) {
                if (await DoLogin(creds)) {
                    return Redirect(returnUrl ?? "/");
                } else {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            } 
            return View(creds);
        }

        [HttpPost]
        public async Task<IActionResult> Logout(string redirectUrl) {
            await signInManager.SignOutAsync();
            return Redirect(redirectUrl ?? "/");
        }

        [HttpPost("/api/account/register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel creds)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = creds.Email, Email = creds.Email };
                var result = await userManager.CreateAsync(user, creds.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return Ok();
                }
                BadRequest(result);
            }
            return BadRequest();
        }

        [HttpPost("/api/account/login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel creds) {
            if (ModelState.IsValid && await DoLogin(creds)) {
               IdentityUser user= await userManager.FindByNameAsync(creds.Name);
                if(await userManager.IsInRoleAsync(user,"Administrator"))
                   return Ok(new {authenticated="true", role="Administrator" });
                else
                    return Ok(new { authenticated = "true", role = "NoAdministrator" });

            }
            return BadRequest();
        }

        [HttpPost("/api/account/logout")]
        public async Task<IActionResult> Logout() {
            await signInManager.SignOutAsync();
            return Ok();
        }

        private async Task<bool> DoLogin(LoginViewModel creds) {
            IdentityUser user = await userManager.FindByNameAsync(creds.Name);
            if (user != null) {
                await signInManager.SignOutAsync();
                Microsoft.AspNetCore.Identity.SignInResult result =
                    await signInManager.PasswordSignInAsync(user, creds.Password, 
                        false, false);
                return result.Succeeded;
            }
            return false;
        }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class LoginViewModel {
        [Required]
        public string Name {get; set;}
        [Required]
        public string Password { get; set;}
    }
}
