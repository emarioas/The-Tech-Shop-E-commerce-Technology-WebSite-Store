import { NgModule } from "@angular/core";
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from "@angular/router";
import { RegistrationService } from "./registration.service";
import { RegistrationComponent } from "./registration.component";

@NgModule({
    imports: [RouterModule, FormsModule, BrowserModule],
    declarations: [RegistrationComponent],
    providers: [RegistrationService],
    exports: [RegistrationComponent]
})
export class RegistrationModule { }
