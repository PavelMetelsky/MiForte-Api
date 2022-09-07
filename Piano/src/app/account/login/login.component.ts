import { Component, ViewEncapsulation } from '@angular/core';
import { NavigateService } from 'src/app/shared/base/navigate.service';

@Component({
  selector: 'p-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class LoginComponent  {
  public paymentInformation: any;
  constructor(
    private navigate: NavigateService
  ) { }

  public toSignup(): void {
    this.navigate.toSignup();
  }

}
