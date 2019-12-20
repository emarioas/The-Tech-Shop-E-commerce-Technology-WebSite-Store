import { Injectable } from "@angular/core";
import { Repository } from "../models/repository";
import { Observable } from "rxjs/Observable";
import { Router } from "@angular/router";
import "rxjs/add/observable/of";
import { AuthenticationService } from "../auth/authentication.service";

@Injectable()
export class RegistrationService {

    constructor(private repo: Repository, public authService: AuthenticationService,
                private router: Router) { }

    registered: boolean = false;
    email: string;
    password: string;
    confirmPswd: string;
    callbackUrl: string = '/';  //after registration is successful, send user to homepage.

    register() : Observable<boolean> {
        this.registered = false;
        return this.repo.register(this.email, this.password)
            .map(response => {
                if (response.ok) {
                    this.registered = true;
                    this.authService.authenticated = true;
                    this.authService.name = this.email;
                    this.confirmPswd = null;
                    this.password = null;
                    this.router.navigateByUrl("/");
                }
                return this.registered;
            })
            .catch(e => {
                this.registered = false;
                return Observable.of(false);  
            });        
    }
}
