import { Component, Input } from '@angular/core';
import { AsyncPipe, formatDate } from '@angular/common';
import { MatIcon } from '@angular/material/icon';
import { PaginatedProducts } from '../../../../../models/PaginatedProducts';

@Component({
  selector: 'products-table',
  standalone: true,
  imports: [AsyncPipe, MatIcon],
  templateUrl: './products-table.component.html',
})
export class ProductsTableComponent {
  @Input() paginatedProducts: PaginatedProducts | null = null;
  @Input() deleteProduct: (id: number) => void = () => {};
  protected readonly formatDate = formatDate;
}
