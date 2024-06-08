import { Routes } from '@angular/router';
import { DashboardLayoutComponent } from './Dashboard/components/dashboard-layout/dashboard-layout.component';
import { DashboardComponent } from './Dashboard/components/dashboard/dashboard.component';
import { AuthLayoutComponent } from './Auth/components/auth-layout/auth-layout.component';
import { LoginComponent } from './Auth/components/auth-layout/login/login.component';
import { RegisterComponent } from './Auth/components/auth-layout/register/register.component';
import { EmailConfirmationComponent } from './Protected/email-confirmation/email-confirmation.component';
import { emailConfirmationGuard } from '../guards/email-confirmation.guard';
import { authGuard } from '../guards/auth.guard';
import { signInGuard } from '../guards/sign-in.guard';
import { ForgotPasswordComponent } from './Auth/components/auth-layout/forgot-password/forgot-password.component';
import { NewPasswordFormComponent } from './Auth/components/auth-layout/new-password-form/new-password-form.component';

export const routes: Routes = [
  {
    path: '',
    component: DashboardLayoutComponent,
    canActivateChild: [authGuard],
    children: [{ path: '', component: DashboardComponent }],
  },
  {
    path: '',
    component: AuthLayoutComponent,
    canActivateChild: [signInGuard],
    children: [
      { path: 'login', component: LoginComponent },
      { path: 'register', component: RegisterComponent },
      {
        path: 'email-confirmation',
        component: EmailConfirmationComponent,
        canActivate: [emailConfirmationGuard],
      },
      {
        path: 'forgot-password',
        component: ForgotPasswordComponent,
      },
      {
        path: 'password-recovery',
        component: NewPasswordFormComponent,
      },
    ],
  },
];
