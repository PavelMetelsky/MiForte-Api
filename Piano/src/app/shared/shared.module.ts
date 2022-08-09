import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NotFoundComponent } from './not-found/not-found.component';
import { PrimengModule } from './primeng.module';

@NgModule({
  imports: [CommonModule, PrimengModule],
  declarations: [NotFoundComponent],
})
export class SharedModule {}
