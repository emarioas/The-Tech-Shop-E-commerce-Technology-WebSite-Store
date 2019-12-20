import { Component } from "@angular/core";
import { Cart } from "../models/cart.model";
import { AuthenticationService } from "../auth/authentication.service";

@Component({
    templateUrl: "cartDetail.component.html"
})
export class CartDetailComponent {

    constructor(public cart: Cart, public authService: AuthenticationService) { }
}
