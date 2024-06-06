import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError, finalize, Observable, of } from 'rxjs';
import { RegisterModel } from '../models/RegisterModel';
import { ErrorsService } from './errors.service';
import { LoadingService } from './loading.service';
import { url } from '../config/config';
import { LoginModel } from '../models/LoginModel';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(
    private http: HttpClient,
    private errorsService: ErrorsService,
    private loadingService: LoadingService,
  ) {}

  register(model: RegisterModel): Observable<RegisterModel> {
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
    return this.http.post(url + '/Account/login', model).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  logout(): Observable<any> {
    this.errorsService.clear();
    this.loadingService.startLoading();
    return this.http.post(url + '/Account/logout', {}).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  private handleErrors(error: HttpErrorResponse): any {
    if (error.status == 200) {
    }
    if (error.status == 400) {
    }
    if (error.status == 401) {
    }
    if (error.status == 404) {
    }
    if (error.status == 500) {
    }

    console.log(error);
  }
}
