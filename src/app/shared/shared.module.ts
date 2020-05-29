import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import * as shared from './components';
import { CatalogComponent } from './components/catalog/catalog.component';
import { TileComponent } from './components/tile/tile.component';

@NgModule({
  declarations: [...shared.components, CatalogComponent, TileComponent],
  imports: [
    CommonModule
  ],
  exports: [
    ...shared.components
  ]
})
export class SharedModule { }
