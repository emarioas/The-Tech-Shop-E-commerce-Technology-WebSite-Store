import {Component } from "@angular/core";
import { RegistrationService } from "./registration.service";

@Component({
    templateUrl: "registration.component.html"
})
export class RegistrationComponent {

    constructor(public regService: RegistrationService) {}

    showError: boolean = false;

    register() {
        this.showError = false;
        if (this.regService.password == this.regService.confirmPswd)
        {
            this.regService.register().subscribe(result => {
                this.showError = !result;
            });
        }
        else
        {
            this.showError = true;
        }
    }
}
