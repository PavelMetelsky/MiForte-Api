import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { UntypedFormControl, UntypedFormGroup, FormGroupName, Validators } from '@angular/forms';

@Component({
  selector: 'app-regestration-data',
  templateUrl: './regestration-data.component.html',
  styleUrls: ['./regestration-data.component.scss']
})
export class RegestrationDataComponent implements OnInit {

  @Output() validEvent = new EventEmitter<boolean>(true);
  public form: UntypedFormGroup;

  ngOnInit(): void {
    
    this.form = new UntypedFormGroup({
      country: new UntypedFormControl('', [Validators.required]),
      town: new UntypedFormControl('', [Validators.required]),
      phone: new UntypedFormControl('', [Validators.required])
    })
  }



}
