import { Component, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'p-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class SignUpComponent {
  public page = 0;
  public pagesOpened: Array<boolean> = [true, false, false];
  public model: ISignUpModel = {
    email: '',
    confirmEmail: '',
    firstName: '',
    lastName: '',
    companyName: '',
    phoneNumber: '',
    termsAndConditionsAccepted: false,
  };

  constructor() {}

  public acceptForm(isValid: boolean): void {
    console.log(isValid);
  }

  public nextPage(): void {
    this.pagesOpened[this.page] = false;
    this.page++;
    this.pagesOpened[this.page] = true;
  }
}
