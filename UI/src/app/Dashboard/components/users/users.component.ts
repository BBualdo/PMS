import { Component, inject } from '@angular/core';
import { AuthService } from '../../../../services/auth.service';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-users',
  standalone: true,
  imports: [AsyncPipe],
  templateUrl: './users.component.html',
})
export class UsersComponent {
  private authService = inject(AuthService);
  currentUser$ = this.authService.currentUser$;
}
