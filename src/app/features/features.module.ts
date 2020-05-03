import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './components/home/home.component';
import { HeroComponent } from './components/hero/hero.component';



@NgModule({
  declarations: [HomeComponent, HeroComponent],
  imports: [
    CommonModule
  ],
  exports: [HomeComponent]
})
export class FeaturesModule { }
