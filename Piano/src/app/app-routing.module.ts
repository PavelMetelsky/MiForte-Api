import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { RegestrationMainComponent } from './regestration-main/regestration-main.component';
import {MainPageComponent} from './main-page/main-page.component';

const routes: Routes = [
  { path: '', component: MainPageComponent},
  { path: 'reg', component: RegestrationMainComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {
}
