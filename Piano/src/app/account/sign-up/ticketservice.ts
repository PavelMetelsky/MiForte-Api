import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable()
export class TicketService {
  public ticketInformation = {
    personalInformation: {
      firstname: '',
      lastname: '',
      age: null,
    },
    seatInformation: {
      class: null,
      wagon: null,
      seat: null,
    },
    paymentInformation: {
      cardholderName: '',
      cardholderNumber: '',
      date: '',
      cvv: '',
      remember: false,
    },
  };

  private paymentComplete = new Subject<any>();

  public paymentComplete$ = this.paymentComplete.asObservable();

  public getTicketInformation() {
    return this.ticketInformation;
  }

  public setTicketInformation(ticketInformation): void {
    this.ticketInformation = ticketInformation;
  }

  public complete(): void {
    this.paymentComplete.next(this.ticketInformation.personalInformation);
  }
}
