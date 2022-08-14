import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NavigateService } from 'src/app/shared/base/navigate.service';
import { TicketService } from '../ticketservice';

@Component({
  selector: 'p-confirmation-step',
  templateUrl: './confirmation-step.component.html',
  styleUrls: ['./confirmation-step.component.scss'],
})
export class ConfirmationStepComponent implements OnInit {
  public ticketInformation: any;

  constructor(
    public ticketService: TicketService,
    private navigate: NavigateService
  ) {}

  public ngOnInit(): void {
    this.ticketInformation = this.ticketService.ticketInformation;
  }

  public complete(): void {
    this.ticketService.complete();

    console.log(this.ticketService.ticketInformation);
  }

  public prevPage(): void {
    this.navigate.toSignupProfile();
  }
}
