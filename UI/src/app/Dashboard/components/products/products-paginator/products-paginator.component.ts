import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'products-paginator',
  standalone: true,
  imports: [],
  templateUrl: './products-paginator.component.html',
})
export class ProductsPaginatorComponent {
  @Input() totalPages: number | null = null;
  currentPage = 1;
  @Output() onPageChange = new EventEmitter<number>();

  next() {
    if (this.currentPage !== this.totalPages) {
      this.currentPage++;
      this.onPageChange.emit(this.currentPage);
    }
  }

  prev() {
    if (this.currentPage !== 1) {
      this.currentPage--;
      this.onPageChange.emit(this.currentPage);
    }
  }
}
