import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { URLS } from 'src/app/constants';

@Injectable()
export class UsersService {
  constructor(private http: HttpClient) {}

  public getUsers(): Observable<any> {
    return this.http.get<any>(URLS.USERS);
  }

  public saveUser(userModel: IUserDetails): Observable<void> {
    return this.http.post<void>(URLS.SAVE_USER, userModel);
  }
}
