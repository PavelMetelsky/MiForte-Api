import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ButtonService } from '../button.service';
import {FormValidationService} from '../form-validation.service'

@Component({
  selector: 'app-regestration-data',
  templateUrl: './regestration-data.component.html',
  styleUrls: ['./regestration-data.component.scss']
})
export class RegestrationDataComponent implements OnInit {

  constructor(private button: ButtonService, private formService: FormValidationService) { }

  form: FormGroup;
  valid: boolean = false;

  submited(){
    this.button.turnButtonOn();
  }

  ngOnInit(): void {
    this.form = new FormGroup({
      country: new FormControl('', [Validators.required]),
      town: new FormControl('', [Validators.required]),
      phone: new FormControl('', [Validators.required])
    })
    
  }


}
