import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TicketService } from '../ticketservice';

@Component({
  selector: 'p-role-step',
  templateUrl: './role-step.component.html',
  styleUrls: ['./role-step.component.scss'],
})
export class RoleStepComponent implements OnInit {
  personalInformation: any;

  submitted: boolean = false;

  constructor(public ticketService: TicketService, private router: Router) {}

  ngOnInit() {
    this.personalInformation =
      this.ticketService.getTicketInformation().personalInformation;
  }

  nextPage() {
    if (
      this.personalInformation.firstname &&
      this.personalInformation.lastname &&
      this.personalInformation.age
    ) {
      this.ticketService.ticketInformation.personalInformation =
        this.personalInformation;

      console.log('sdfdf');
      this.router.navigate(['account', 'signup', 'phone']);

      return;
    }

    this.submitted = true;
  }
}
