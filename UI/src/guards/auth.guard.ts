import { CanActivateChildFn, Router } from '@angular/router';
import { inject } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { map, Observable, tap } from 'rxjs';

export const authGuard: CanActivateChildFn = (
  route,
  state,
): Observable<boolean> => {
  const authService = inject(AuthService);
  const router = inject(Router);
  return authService.getCurrentUser().pipe(
    map((user) => !!user),
    tap((isLoggedIn) => {
      if (!isLoggedIn) router.navigate(['/login']);
    }),
  );
};
