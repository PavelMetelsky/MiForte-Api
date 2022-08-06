import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccountComponent } from './account.component';
import { AccountRoutingModule } from './account.routing';
import { SharedModule } from '../shared/shared.module';
import { LoginComponent } from './login/login.component';

@NgModule({
  imports: [CommonModule, AccountRoutingModule, SharedModule],
  declarations: [AccountComponent, LoginComponent],
})
export class AccountModule {}
