import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import {
  BehaviorSubject,
  catchError,
  finalize,
  Observable,
  of,
  tap,
} from 'rxjs';
import { RegisterModel } from '../models/RegisterModel';
import { ErrorsService } from './errors.service';
import { LoadingService } from './loading.service';
import { url } from '../config/config';
import { LoginModel } from '../models/LoginModel';
import { Dialog } from '@angular/cdk/dialog';
import { ErrorDialogComponent } from '../app/Shared/error-dialog/error-dialog.component';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private currentUserSubject: BehaviorSubject<User | undefined> =
    new BehaviorSubject<User | undefined>(undefined);
  currentUser$ = this.currentUserSubject.asObservable();

  constructor(
    private http: HttpClient,
    private errorsService: ErrorsService,
    private loadingService: LoadingService,
    private dialog: Dialog,
  ) {}

  getCurrentUser(): Observable<User | undefined> {
    this.errorsService.clear();
    this.loadingService.startLoading();
    return this.http.get<User | undefined>(url + 'Account/currentUser').pipe(
      tap((user) => this.currentUserSubject.next(user)),
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  register(model: RegisterModel): Observable<string> {
    this.errorsService.clear();
    this.loadingService.startLoading();
    return this.http.post(url + 'Account/register', model).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  login(model: LoginModel): Observable<LoginModel> {
    this.errorsService.clear();
    this.loadingService.startLoading();
    return this.http.post<LoginModel>(url + 'Account/login', model).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  logout(): Observable<any> {
    this.errorsService.clear();
    this.loadingService.startLoading();
    return this.http.post(url + 'Account/logout', {}).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  confirmEmail(userId: string, token: string): Observable<string> {
    this.errorsService.clear();
    this.loadingService.startLoading();
    return this.http
      .get(url + `Account/confirmEmail/?userId=${userId}&token=${token}`, {
        responseType: 'text',
      })
      .pipe(
        catchError((error) => of(this.handleErrors(error))),
        finalize(() => this.loadingService.stopLoading()),
      );
  }

  private handleErrors(error: HttpErrorResponse): any {
    switch (error.status) {
      case 500: {
        this.errorsService.add('Something went wrong. Try again later.');
        break;
      }
      case 409: {
        error.error.forEach((err: { code: string; description: string }) =>
          this.errorsService.add(err.description),
        );

        break;
      }
      case 401: {
        if (error.error) {
          error.error.forEach((err: { code: string; description: string }) =>
            this.errorsService.add(err.description),
          );
        } else {
          this.errorsService.add('You must be signed in to access this page.');
        }

        break;
      }
      case 0: {
        this.errorsService.add('Connection failed. Please try again later.');
        break;
      }
    }

    this.dialog.open(ErrorDialogComponent);

    console.log(error);
  }
}
