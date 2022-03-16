import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { RegestrationComponent } from './regestration/regestration.component';
import { RegestrationMainComponent } from './regestration-main/regestration-main.component';
import { RegestrationRoleComponent } from './regestration-role/regestration-role.component';

@NgModule({
  declarations: [AppComponent, RegestrationComponent, RegestrationMainComponent, RegestrationRoleComponent],
  imports: [BrowserModule, HttpClientModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
