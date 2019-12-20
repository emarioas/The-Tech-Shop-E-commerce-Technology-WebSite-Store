import { Injectable } from "@angular/core";
import { Repository } from "../models/repository";
import { Observable } from "rxjs/Observable";
import { Router } from "@angular/router";
import "rxjs/add/observable/of";

@Injectable()
export class AuthenticationService {

    constructor(private repo: Repository, 
                private router: Router) { }

    authenticated: boolean = false;
    name: string;
    password: string;
    callbackUrl: string;
    role: String;

    login() : Observable<boolean> {
        this.authenticated = false;
        return this.repo.login(this.name, this.password)
            .map(response => {
                if (response.json().authenticated=='true') {
                    this.authenticated = true;
                    this.password = null;
                    this.role = response.json().role;
                    if (this.role == 'Administrator')
                    {
                        this.router.navigateByUrl("/admin/overview");
                    }
                    else
                    {
                        this.router.navigateByUrl("/");
                    }
                }
                return this.authenticated;
            })
            .catch(e => {
                this.authenticated = false;
                return Observable.of(false);  
            });
        
    }

    logout() {
        this.authenticated = false;
        this.role = "";
        this.repo.logout();
        this.router.navigateByUrl("/");
        
    }
}
