import { HttpHeaders, HttpParams, HttpClient } from '@angular/common/http';
import { Component, ViewEncapsulation } from '@angular/core';
import { Observable } from 'rxjs';
import { WEB_API_URL } from 'src/app/constants';
import { NavigateService } from 'src/app/shared/base/navigate.service';
import { StorageService } from 'src/app/storage.service';

interface ILoginModel {
  email: string;
  password: string;
  // rememberMe: boolean;
}

@Component({
  selector: 'p-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class LoginComponent {
  private usersUrl = `${WEB_API_URL}/Users/login`;
  protected headers: HttpHeaders = this.getHeaders();
  protected options = {
    headers: this.headers,
    params: new HttpParams(),
  };

  public model: ILoginModel = {
    email: '',
    password: '',
    //rememberMe: false,
  };

  constructor(
    private navigate: NavigateService,
    private http: HttpClient,
    private storageService: StorageService
  ) {}

  public toLogin(): void {
    // console.log(this.model);
    this.login(this.model).subscribe((data: any) => {
      if (data.flag) {
        //console.log('successful');
        this.storageService.setItem('userModel', this.model);
        this.navigate.toUserProfile();
      } else {
        console.log('error');
      }
    });
  }

  public toSignup(): void {
    this.navigate.toSignup();
  }

  private login(model: ILoginModel): Observable<any> {
    return this.http.post<any>(this.usersUrl, model, this.options);
  }

  protected getHeaders(): HttpHeaders {
    return new HttpHeaders({
      'Access-Control-Allow-Origin': '*',
    });
  }
}
