import { Component, inject } from '@angular/core';
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
import { RegisterModel } from '../../../../../models/RegisterModel';
import { AuthService } from '../../../../../services/auth.service';

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

  private authService = inject(AuthService);

  register() {
    this.registerForm.markAllAsTouched();

    if (this.registerForm.valid) {
      const formValues = this.registerForm.value;
      const model: RegisterModel = {
        firstName: formValues.firstName,
        lastName: formValues.lastName,
        email: formValues.email,
        password: formValues.password,
      };

      this.authService.register(model).subscribe();
    }
  }
}
