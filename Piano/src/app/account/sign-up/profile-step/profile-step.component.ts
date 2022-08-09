import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TicketService } from '../ticketservice';

@Component({
  selector: 'p-profile-step',
  templateUrl: './profile-step.component.html',
  styleUrls: ['./profile-step.component.scss'],
})
export class ProfileStepComponent implements OnInit {
  paymentInformation: any;

  constructor(public ticketService: TicketService, private router: Router) {}

  ngOnInit() {
    this.paymentInformation =
      this.ticketService.ticketInformation.paymentInformation;
  }

  nextPage() {
    this.ticketService.ticketInformation.paymentInformation =
      this.paymentInformation;
    this.router.navigate(['account/signup/confirmation']);
  }

  prevPage() {
    this.router.navigate(['account/signup/phone']);
  }
}
