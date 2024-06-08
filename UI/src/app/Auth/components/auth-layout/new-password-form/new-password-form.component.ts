import { Component, inject } from '@angular/core';
import { AsyncPipe, NgClass } from '@angular/common';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { LoadingSpinnerComponent } from '../../../../Shared/loading-spinner/loading-spinner.component';
import { RouterLink } from '@angular/router';
import { passwordValidator } from '../../../../../validators/password.validator';
import { matchPasswordValidator } from '../../../../../validators/match-password.validator';
import { LoadingService } from '../../../../../services/loading.service';

@Component({
  selector: 'app-new-password-form',
  standalone: true,
  imports: [
    AsyncPipe,
    FormsModule,
    LoadingSpinnerComponent,
    ReactiveFormsModule,
    RouterLink,
    NgClass,
  ],
  templateUrl: './new-password-form.component.html',
})
export class NewPasswordFormComponent {
  passwordForm: FormGroup = new FormGroup(
    {
      password: new FormControl<string>('', [
        Validators.required,
        passwordValidator,
      ]),
      confirmPassword: new FormControl<string>('', [Validators.required]),
    },
    [matchPasswordValidator],
  );

  loadingService = inject(LoadingService);

  resetPassword() {}
}
