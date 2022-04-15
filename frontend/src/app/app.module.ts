import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MessageService, SharedModule } from "primeng/api";
import { HTTP_INTERCEPTORS, HttpClientModule } from "@angular/common/http";
import { JwtInterceptor } from "./core/interceptors/jwt.interceptor";
import { MainModule } from "./modules/main/main.module";
import { MessagesModule } from "primeng/messages";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";

@NgModule({
  declarations: [
    AppComponent
  ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        SharedModule,
        HttpClientModule,
        MainModule,
        BrowserAnimationsModule,
        MessagesModule,
        MessagesModule
    ],
  providers: [
      { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
      MessageService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
