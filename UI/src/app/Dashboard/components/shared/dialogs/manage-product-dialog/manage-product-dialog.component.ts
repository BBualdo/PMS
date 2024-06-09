import { Component, inject } from '@angular/core';
import { DIALOG_DATA, DialogRef } from '@angular/cdk/dialog';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { MatIcon } from '@angular/material/icon';

@Component({
  selector: 'app-manage-product-dialog',
  standalone: true,
  imports: [MatIcon, FormsModule, ReactiveFormsModule],
  templateUrl: './manage-product-dialog.component.html',
})
export class ManageProductDialogComponent {
  public data = inject(DIALOG_DATA);
  private dialogRef = inject(DialogRef);

  title = this.data.title;

  productForm = new FormGroup({
    name: new FormControl<string>(this.data.product?.name || '', [
      Validators.required,
      Validators.minLength(6),
      Validators.maxLength(200),
    ]),
    price: new FormControl<number>(this.data.product?.price || 999.99, [
      Validators.required,
      Validators.min(1),
    ]),
    isActive: new FormControl<boolean>(this.data.product?.isActive || true, [
      Validators.required,
    ]),
  });

  close() {
    this.dialogRef.close();
  }

  addProduct() {
    console.log(this.productForm.value);
  }
}
