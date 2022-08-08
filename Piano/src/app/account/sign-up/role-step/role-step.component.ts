import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'p-role-step',
  templateUrl: './role-step.component.html',
  styleUrls: ['./role-step.component.scss'],
})
export class RoleStepComponent implements OnInit {
  public isStudent = false;
  public isMentor = false;
  constructor() {}

  ngOnInit(): void {}

  studentClick() {
    this.isStudent = true;
    this.isMentor = false;
    // this.reg.role = 'Student';
  }

  mentorClick() {
    this.isStudent = false;
    this.isMentor = true;
    // this.reg.role = 'Mentor';
  }
}
