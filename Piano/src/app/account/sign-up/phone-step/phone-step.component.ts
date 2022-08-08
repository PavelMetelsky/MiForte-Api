import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'p-phone-step',
  templateUrl: './phone-step.component.html',
  styleUrls: ['./phone-step.component.scss'],
})
export class PhoneStepComponent implements OnInit {
  public isStudent = false;
  public isMentor = false;
  constructor() {}

  ngOnInit(): void {}
}
