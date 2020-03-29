import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {FrameworkBodyComponent} from "./framework-body/framework-body.component";
import {ContentComponent} from "./content/content.component";
import {TitleBarComponent} from "./title-bar/title-bar.component";


@NgModule({
  declarations: [
    FrameworkBodyComponent,
    ContentComponent,
    TitleBarComponent
  ],
  exports: [
    FrameworkBodyComponent,
    ContentComponent
  ],
  imports: [
    CommonModule
  ]
})
export class FwModule {
}
