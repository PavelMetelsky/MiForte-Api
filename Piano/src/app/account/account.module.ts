import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccountComponent } from './account.component';
import { AccountRoutingModule } from './account.routing';
import { SharedModule } from '../shared/shared.module';
import { LoginComponent } from './login/login.component';
import { RoleStepComponent } from './sign-up/role-step/role-step.component';
import { ProfileStepComponent } from './sign-up/profile-step/profile-step.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { PhoneStepComponent } from './sign-up/phone-step/phone-step.component';
import { PrimengModule } from '../shared/primeng.module';

@NgModule({
  imports: [CommonModule, AccountRoutingModule, SharedModule, PrimengModule],
  declarations: [
    AccountComponent,
    LoginComponent,
    RoleStepComponent,
    ProfileStepComponent,
    SignUpComponent,
    PhoneStepComponent,
  ],
})
export class AccountModule {}
