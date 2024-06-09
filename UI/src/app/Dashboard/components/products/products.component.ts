import { Component, inject, OnInit } from '@angular/core';
import { ProductsService } from '../../../../services/products.service';
import { AsyncPipe, formatDate } from '@angular/common';
import { MatIcon } from '@angular/material/icon';
import { ProductsTableComponent } from './products-table/products-table.component';
import { ProductsPaginatorComponent } from './products-paginator/products-paginator.component';
import { PaginatedProducts } from '../../../../models/PaginatedProducts';
import { Product } from '../../../../models/Product';
import { Dialog } from '@angular/cdk/dialog';
import { ConfirmDialogComponent } from '../shared/dialogs/confirm-dialog/confirm-dialog.component';
import { ManageProductDialogComponent } from '../shared/dialogs/manage-product-dialog/manage-product-dialog.component';
import { ScrollStrategyOptions } from '@angular/cdk/overlay';

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
  private dialog = inject(Dialog);

  products$ = this.productsService.products$;
  currentPage = 1;

  ngOnInit() {
    this.productsService.getProducts().subscribe();
  }

  addProduct() {
    this.dialog.open(ManageProductDialogComponent, {
      data: { title: 'Add Product' },
    });
  }

  updateProduct(product: Product) {
    this.dialog.open(ManageProductDialogComponent, {
      data: { title: 'Update Product', product: product },
    });
  }

  deleteProduct(product: Product) {
    const dialogRef = this.dialog.open(ConfirmDialogComponent, {
      data: { name: product.name },
    });
    dialogRef.closed.subscribe((result) => {
      if (result == true) {
        this.productsService
          .deleteProduct(product.id)
          .subscribe(() => this.refreshProducts(this.currentPage));
      }
    });
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
