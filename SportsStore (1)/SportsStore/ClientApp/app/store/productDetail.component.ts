import { Component } from '@angular/core';
import { Repository } from "../models/repository";
import { Product } from "../models/product.model";
import { Router, ActivatedRoute } from "@angular/router";
import { Cart } from '../models/cart.model';
import { AuthenticationService } from '../auth/authentication.service';


export class ProductListComponent {

    constructor(private repo: Repository, private cart: Cart) { }

    get products(): Product[] {
        if (this.repo.products != null && this.repo.products.length > 0) {
            let pageIndex = (this.repo.pagination.currentPage - 1)
                * this.repo.pagination.productsPerPage;
            return this.repo.products.slice(pageIndex,
                pageIndex + this.repo.pagination.productsPerPage);
        }
    }
}

export class ProductSelectionComponent {
    constructor(public authService: AuthenticationService) { }

}

@Component({
    selector: "product-detail",
    templateUrl: "productDetail.component.html"
})
export class ProductDetailComponent {

    constructor(private repo: Repository,
                router: Router,
                activeRoute: ActivatedRoute,
                public cart: Cart
                ) {

        let id = Number.parseInt(activeRoute.snapshot.params["id"]);
        if (id) {
            this.repo.getProduct(id);
        } else {
            router.navigateByUrl("/");
        }
    }
    addToCart(product: Product) {
        this.cart.addProduct(product);
    }
    get product(): Product {
        return this.repo.product;
    }
}
