import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import * as feature from './components';
import { SharedModule } from "../shared/shared.module";

@NgModule({
  declarations: [...feature.components],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports: [...feature.components]
})
export class FeaturesModule { }
