import { Component, inject, OnInit } from '@angular/core';
import { ProductsService } from '../../../../services/products.service';
import { AsyncPipe, formatDate } from '@angular/common';
import { MatIcon } from '@angular/material/icon';
import { ProductsTableComponent } from './products-table/products-table.component';
import { ProductsPaginatorComponent } from './products-paginator/products-paginator.component';
import { PaginatedProducts } from '../../../../models/PaginatedProducts';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [
    AsyncPipe,
    MatIcon,
    ProductsTableComponent,
    ProductsPaginatorComponent,
  ],
  templateUrl: './products.component.html',
})
export class ProductsComponent implements OnInit {
  private productsService = inject(ProductsService);

  products$ = this.productsService.products$;
  currentPage = 1;

  ngOnInit() {
    this.productsService.getProducts().subscribe();
  }

  deleteProduct(id: number) {
    this.productsService
      .deleteProduct(id)
      .subscribe(() => this.refreshProducts(this.currentPage));
  }

  refreshProducts(page: number) {
    this.productsService
      .getProducts(page)
      .subscribe((paginatedProducts: PaginatedProducts) => {
        if (this.currentPage !== 1 && paginatedProducts.products.length === 0) {
          this.currentPage--;
          this.refreshProducts(this.currentPage);
        }
      });
  }

  setCurrentPage(page: number) {
    this.currentPage = page;
  }

  protected readonly formatDate = formatDate;
}
