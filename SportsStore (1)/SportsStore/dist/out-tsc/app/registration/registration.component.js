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
var registration_service_1 = require("./registration.service");
var RegistrationComponent = /** @class */ (function () {
    function RegistrationComponent(regService) {
        this.regService = regService;
        this.showError = false;
    }
    RegistrationComponent.prototype.register = function () {
        var _this = this;
        this.showError = false;
        if (this.regService.password == this.regService.confirmPswd) {
            this.regService.register().subscribe(function (result) {
                _this.showError = !result;
            });
        }
        else {
            this.showError = true;
        }
    };
    RegistrationComponent = __decorate([
        core_1.Component({
            templateUrl: "registration.component.html"
        }),
        __metadata("design:paramtypes", [registration_service_1.RegistrationService])
    ], RegistrationComponent);
    return RegistrationComponent;
}());
exports.RegistrationComponent = RegistrationComponent;
//# sourceMappingURL=registration.component.js.map