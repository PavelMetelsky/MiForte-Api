import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { WEB_API_URL } from 'src/app/constants';
import { NavigateService } from 'src/app/shared/base/navigate.service';
import { TicketService } from '../ticketservice';

interface UserDetails {
  Role: number;
  Country: string;
  City: string;
  Telephone: string;
  Username: string;
  Email: string;
  Password: string;
}

@Component({
  selector: 'p-confirmation-step',
  templateUrl: './confirmation-step.component.html',
  styleUrls: ['./confirmation-step.component.scss'],
})
export class ConfirmationStepComponent implements OnInit {
  public userModel: UserDetails = {} as UserDetails;
  public ticketInformation: any;

  private usersUrl = `${WEB_API_URL}/Users`;
  protected headers: HttpHeaders = this.getHeaders();
  protected options = {
    headers: this.headers,
    params: new HttpParams(),
  };

  constructor(
    public ticketService: TicketService,
    private navigate: NavigateService,
    private http: HttpClient
  ) {}

  public ngOnInit(): void {
    this.ticketInformation = this.ticketService.ticketInformation;
  }

  public complete(): void {
    this.ticketService.complete();

    this.userModel.Username =
      this.ticketInformation.paymentInformation.fullName;
    this.userModel.Email = this.ticketInformation.paymentInformation.login;
    this.userModel.Password =
      this.ticketInformation.paymentInformation.password;

    console.log(this.userModel);

    this.saveUser().subscribe((data: any) => {
      console.log(...data);
      console.log('saved');
    });

    this.navigate.toFinish();
  }

  private saveUser(): Observable<void> {
    return this.http.post<void>(this.usersUrl, this.userModel, this.options);
  }

  protected getHeaders(): HttpHeaders {
    return new HttpHeaders({
      'Access-Control-Allow-Origin': '*',
    });
  }

  public prevPage(): void {
    this.navigate.toSignupProfile();
  }
}
