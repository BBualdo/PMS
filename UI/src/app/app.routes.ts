import { Routes } from '@angular/router';
import { DashboardLayoutComponent } from './Dashboard/components/dashboard-layout/dashboard-layout.component';
import { DashboardComponent } from './Dashboard/components/dashboard/dashboard.component';
import { AuthLayoutComponent } from './Auth/components/auth-layout/auth-layout.component';
import { LoginComponent } from './Auth/components/auth-layout/login/login.component';
import { RegisterComponent } from './Auth/components/auth-layout/register/register.component';

export const routes: Routes = [
  {
    path: '',
    component: DashboardLayoutComponent,
    children: [{ path: '', component: DashboardComponent }],
  },
  {
    path: '',
    component: AuthLayoutComponent,
    children: [
      { path: 'login', component: LoginComponent },
      { path: 'register', component: RegisterComponent },
    ],
  },
];
