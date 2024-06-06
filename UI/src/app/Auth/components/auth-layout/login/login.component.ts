import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { emailValidator } from '../../../../../validators/email.validator';
import { LoginModel } from '../../../../../models/LoginModel';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [RouterLink, FormsModule, ReactiveFormsModule, NgClass],
  templateUrl: './login.component.html',
})
export class LoginComponent {
  loginForm: FormGroup = new FormGroup({
    email: new FormControl<string>('', [Validators.required, emailValidator]),
    password: new FormControl('', [Validators.required]),
  });

  login() {
    this.loginForm.markAllAsTouched();

    if (this.loginForm.valid) {
      const formValues = this.loginForm.value;
      const model: LoginModel = {
        email: formValues.email,
        password: formValues.password,
      };

      console.log(model);
    }
  }
}
