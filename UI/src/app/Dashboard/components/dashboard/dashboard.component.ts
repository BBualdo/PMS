import { Component, inject } from '@angular/core';
import { AuthService } from '../../../../services/auth.service';
import { AsyncPipe } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [AsyncPipe],
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent {
  private authService = inject(AuthService);
  private router = inject(Router);
  currentUser$ = this.authService.currentUser$;

  logout() {
    this.authService.logout().subscribe(() => this.router.navigate(['/login']));
  }
}
