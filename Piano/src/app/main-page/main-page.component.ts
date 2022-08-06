import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'p-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss'],
})
export class MainPageComponent implements OnInit {
  public user: string = 'init';
  private usersUrl = 'https://localhost:7196/api/Users';
  protected headers: HttpHeaders = this.getHeaders();
  protected options = {
    headers: this.headers,
    params: new HttpParams(),
  };

  constructor(private http: HttpClient) {}

  public ngOnInit(): void {
    this.getUsers().subscribe((data: any) => {
      this.user = { ...data };
      console.log(...data);
    });
  }

  private getUsers(): Observable<any> {
    this.options.headers = this.getHeaders();

    return this.http.get<any>(this.usersUrl, this.options);
  }

  protected getHeaders(): HttpHeaders {
    return new HttpHeaders({
      'Access-Control-Allow-Origin': '*',
    });
  }
}
