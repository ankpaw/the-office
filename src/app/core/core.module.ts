import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import * as core from "./components";
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [...core.components],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports: [...core.components]
})
export class CoreModule { }
