import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-regestration-role',
  templateUrl: './regestration-role.component.html',
  styleUrls: ['./regestration-role.component.scss']
})
export class RegestrationRoleComponent implements OnInit {

  public isStudent = false;
  public isMentor = false;
  public enoughInfo = false;
  constructor() { }

  ngOnInit(): void {
  }

  studentClick(){
    this.isStudent = true;
    this.isMentor = false;
    this.enoughInfo = true;
  }

  mentorClick(){
    this.isStudent = false;
    this.isMentor = true;
    this.enoughInfo = true;
  }

}
