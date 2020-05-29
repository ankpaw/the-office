import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import * as shared from './components';
import { CatalogComponent } from './components/catalog/catalog.component';

@NgModule({
  declarations: [...shared.components, CatalogComponent],
  imports: [
    CommonModule
  ],
  exports: [
    ...shared.components
  ]
})
export class SharedModule { }
