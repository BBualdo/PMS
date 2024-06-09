import { Component, Input } from '@angular/core';

@Component({
  selector: 'products-paginator',
  standalone: true,
  imports: [],
  templateUrl: './products-paginator.component.html',
})
export class ProductsPaginatorComponent {
  @Input() totalPages: number | null = null;
  currentPage = 1;
}
