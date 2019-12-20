"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var repository_1 = require("../models/repository");
var Observable_1 = require("rxjs/Observable");
var router_1 = require("@angular/router");
require("rxjs/add/observable/of");
var authentication_service_1 = require("../auth/authentication.service");
var RegistrationService = /** @class */ (function () {
    function RegistrationService(repo, authService, router) {
        this.repo = repo;
        this.authService = authService;
        this.router = router;
        this.registered = false;
        this.callbackUrl = '/'; //after registration is successful, send user to homepage.
    }
    RegistrationService.prototype.register = function () {
        var _this = this;
        this.registered = false;
        return this.repo.register(this.email, this.password)
            .map(function (response) {
            if (response.ok) {
                _this.registered = true;
                _this.authService.authenticated = true;
                _this.authService.name = _this.email;
                _this.confirmPswd = null;
                _this.password = null;
                _this.router.navigateByUrl("/");
            }
            return _this.registered;
        })
            .catch(function (e) {
            _this.registered = false;
            return Observable_1.Observable.of(false);
        });
    };
    RegistrationService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [repository_1.Repository, authentication_service_1.AuthenticationService,
            router_1.Router])
    ], RegistrationService);
    return RegistrationService;
}());
exports.RegistrationService = RegistrationService;
//# sourceMappingURL=registration.service.js.map