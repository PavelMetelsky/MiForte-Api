import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TicketService } from '../ticketservice';

@Component({
  selector: 'p-confirmation-step',
  templateUrl: './confirmation-step.component.html',
  styleUrls: ['./confirmation-step.component.scss'],
})
export class ConfirmationStepComponent implements OnInit {
  ticketInformation: any;

  constructor(public ticketService: TicketService, private router: Router) {}

  ngOnInit() {
    this.ticketInformation = this.ticketService.ticketInformation;
  }

  complete() {
    this.ticketService.complete();
  }

  prevPage() {
    this.router.navigate(['account/signup/profile']);
  }
}
