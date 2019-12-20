import { Component } from "@angular/core";
import { AuthenticationService } from "../auth/authentication.service";
import { Repository } from "../models/repository";

export class AdminComponent {

    constructor(private repo: Repository,
        public authService: AuthenticationService) {
        repo.filter.reset();
        repo.filter.related = true;
        this.repo.getProducts();
        this.repo.getSuppliers();
        this.repo.getOrders();
    }
}

@Component({
    selector: "store-products",
    templateUrl: "productSelection.component.html"
})
export class ProductSelectionComponent {
    constructor(public authService: AuthenticationService) { }

}
