import { Component, inject, OnInit } from '@angular/core';
import { ProductsService } from '../../../../services/products.service';
import { AsyncPipe, formatDate } from '@angular/common';
import { MatIcon } from '@angular/material/icon';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [AsyncPipe, MatIcon],
  templateUrl: './products.component.html',
})
export class ProductsComponent implements OnInit {
  private productsService = inject(ProductsService);

  products$ = this.productsService.products$;

  ngOnInit() {
    this.productsService.getProducts().subscribe((value) => console.log(value));
  }

  protected readonly formatDate = formatDate;
}
