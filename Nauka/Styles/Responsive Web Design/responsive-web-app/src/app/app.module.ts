import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './shared/component/footer/footer.component';
import { Error404Component } from './shared/component/error404/error404.component';
import { LibraryListComponentComponent } from './shared/component/library-list-component/library-list-component.component';
import { HeaderComponent } from './shared/component/header/header.component';
import { NavbarComponent } from './shared/component/header/navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    Error404Component,
    LibraryListComponentComponent,
    HeaderComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
