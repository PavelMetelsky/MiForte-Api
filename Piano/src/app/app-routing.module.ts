import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegestrationMainComponent } from './regestration-main/regestration-main.component';
import { MainPageComponent } from './main-page/main-page.component';
import { NotFoundComponent } from './shared/not-found/not-found.component';

const routes: Routes = [
  { path: '', component: MainPageComponent },
  { path: 'reg', component: RegestrationMainComponent },
  {
    path: 'account',
    loadChildren: () => import('./account').then((m) => m.AccountModule),
  },
  { path: '404', component: NotFoundComponent },
  { path: '**', redirectTo: '404' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule],
})
export class AppRoutingModule {}
