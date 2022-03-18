import { Component, OnInit } from '@angular/core';
import { ButtonService } from '../button.service';

@Component({
  selector: 'app-regestration-main',
  templateUrl: './regestration-main.component.html',
  styleUrls: ['./regestration-main.component.scss']
})
export class RegestrationMainComponent implements OnInit {

  constructor(public btnService: ButtonService) { }

  page = 0;
  pagesOpened:Array<boolean> = [true, false, false];
  ngOnInit(): void { 
  }

  nextPage(){
    this.pagesOpened[this.page] = false;
    this.page++;
    this.pagesOpened[this.page] = true;
    this.btnService.turnButtonOff();
    
  }
}
