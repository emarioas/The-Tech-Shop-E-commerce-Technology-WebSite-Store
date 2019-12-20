using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            //context.Database.EnsureDeleted();  //if a database exists, delete it.
            context.Database.Migrate();
            if (context.Products.Count() == 0)
            {
                var s1 = new Supplier
                {
                    Name = "Apple",
                    City = "San Jose",
                    State = "CA"
                };
                var s2 = new Supplier
                {
                    Name = "Samsung INk",
                    City = "Chicago",
                    State = "IL"
                };
                var s3 = new Supplier
                {
                    Name = "Tech Phones",
                    City = "New York",
                    State = "NY"
                };

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Iphone 11 Pro Max",
                        Description = "All-new triple-camera system (Ultra Wide, Wide, Telephoto)",
                        Category = "Apple",
                        Price = 999,
                        Image = "Iphone11ProMax.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Iphone 11",
                        Description = "All-new dual-camera system (Ultra Wide, Wide)",
                        Category = "Apple",
                        Price = 699,
                        Image = "Iphone11.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 2 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Iphone XR",
                        Description = "Single Camera System",
                        Category = "Apple",
                        Price = 599,
                        Image = "Iphone-XR.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Iphone XS",
                        Description = "Dual 12MP Wide and Telephoto cameras",
                        Category = "Apple",
                        Price = 899,
                        Image = "Iphone-XS.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Iphone X",
                        Description = "5.8-inch (diagonal) all-screen OLED Multi‑Touch display1",
                        Category = "Apple",
                        Price = 679,
                        Image = "Iphone-X.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Iphone 8",
                        Description = "4.7-inch (diagonal) widescreen LCD Multi‑Touch display with IPS technology",
                        Category = "Apple",
                        Price = 779,
                        Image = "Iphone8.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Iphone 7 Plus",
                        Description = "5.5-inch (diagonal) widescreen LCD Multi‑Touch display with IPS technology",
                        Category = "Apple",
                        Price = 750,
                        Image = "Iphone7Plus.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Iphone 7 ",
                        Description = "4.7-inch (diagonal) widescreen LCD Multi‑Touch display with IPS technology",
                        Category = "Apple",
                        Price = 679,
                        Image = "Iphone7.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Iphone 6S Plus ",
                        Description = "5.5-inch (diagonal) widescreen LCD Multi‑Touch display with IPS technology",
                        Category = "Apple",
                        Price = 650,
                        Image = "Iphone7.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Iphone 6S Plus ",
                        Description = "5.5-inch (diagonal) widescreen LCD Multi‑Touch display with IPS technology",
                        Category = "Apple",
                        Price = 650,
                        Image = "Iphone7.png",
                        Supplier = s1,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Samsung Fold",
                        Description = "Unfold to the most expansive Infinity Display ever ",
                        Category = "Samsung",
                        Price = 1980,
                        Image = "Fold.png",
                        Supplier = s2,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Samsung A50",
                        Description = "With an all-day battery that lasts up to 35 hours, the Galaxy A50 keeps up with your fast pace",
                        Category = "Samsung",
                        Price = 299,
                        Image = "A50.png",
                        Supplier = s2,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Samsung S",
                        Description = "An all-day battery that intelligently powers every scroll, click, call, tap, playlist and season finale you can throw at it.",
                        Category = "Samsung",
                        Price = 299,
                        Image = "A50.png",
                        Supplier = s2,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Samsung Note 10",
                        Description = "Intelligent power that learns from how you work and play to optimize battery life.",
                        Category = "Samsung",
                        Price = 949,
                        Image = "Note10.png",
                        Supplier = s2,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Samsung J3",
                        Description = "With Samsung quality and design, the J Series gives you everything you need and nothing you don’t.",
                        Category = "Samsung",
                        Price = 169,
                        Image = "J.png",
                        Supplier = s2,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Samsung Quick-Charger adapte table",
                        Description = "RAV Power 36w quick charge 3.0 wall charger",
                        Category = "Accessories",
                        Price = 29.95m,
                        Image = "SW.png",
                        Supplier = s3,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Samsung A50 Case",
                        Description = "A revolutionary magentic USB cable that make your charge easy",
                        Category = "Accessories",
                        Price = 22.50m,
                        Image = "Case.png",
                        Supplier = s3,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Galaxy Note10 S Pen, Black",
                        Description = "Official S Pen. Compatible with Galaxy Note10",
                        Category = "Accessories",
                        Price = 29.99m,
                        Image = "Pen.png",
                        Supplier = s3,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Apple Airpods Pro",
                        Description = "AirPods Pro offer a more customizable fit with three sizes of flexible silicone tips to choose from.",
                        Category = "Accessories",
                        Price = 250.00m,
                        Image = "Pods.png",
                        Supplier = s3,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}

                    },
                    new Product
                    {
                        Name = "Apple Wireless Charger",
                        Description = "Belkin BOOST UP Special Edition Wireless Charging Pad",
                        Category = "Accessories",
                        Price = 60.00m,
                        Image = "Pods.png",
                        Supplier = s3,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                    new Product
                    {
                        Name = "Apple Wired Charger",
                        Description = "USB-C to Lightning Cable (1 m)",
                        Category = "Accessories",
                        Price = 60.00m,
                        Image = "AppleW.png",
                        Supplier = s3,
                        Ratings = new List<Rating> {
                            new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    });
                context.SaveChanges();
            }
        }

    }
}
