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
import { passwordValidator } from '../../../../../validators/password.validator';
import { matchPasswordValidator } from '../../../../../validators/match-password.validator';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [RouterLink, FormsModule, ReactiveFormsModule, NgClass],
  templateUrl: './register.component.html',
})
export class RegisterComponent {
  registerForm: FormGroup = new FormGroup(
    {
      firstName: new FormControl<string>('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
      ]),
      lastName: new FormControl<string>('', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(50),
      ]),
      email: new FormControl<string>('', [Validators.required, emailValidator]),
      password: new FormControl('', [
        Validators.required,
        Validators.minLength(6),
        passwordValidator,
      ]),
      confirmPassword: new FormControl('', [
        Validators.required,
        Validators.minLength(6),
      ]),
    },
    [matchPasswordValidator],
  );

  register() {
    this.registerForm.markAllAsTouched();

    if (this.registerForm.valid) {
      console.log(this.registerForm.value);
    }
  }
}
