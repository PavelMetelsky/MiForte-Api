import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { RegestrationMainComponent } from './regestration-main/regestration-main.component';

const routes: Routes = [
  { path: '', component: AppComponent},
  { path: 'reg', component: RegestrationMainComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {
  
}
