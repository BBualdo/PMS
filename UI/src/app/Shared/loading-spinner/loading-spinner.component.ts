import { Component, Input } from '@angular/core';

@Component({
  selector: 'loading-spinner',
  standalone: true,
  imports: [],
  templateUrl: './loading-spinner.component.html',
})
export class LoadingSpinnerComponent {
  @Input() class = '';
}
