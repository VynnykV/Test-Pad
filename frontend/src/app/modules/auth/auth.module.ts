import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { InputTextModule } from "primeng/inputtext";
import { ButtonModule } from "primeng/button";
import { RippleModule } from "primeng/ripple";
import { ReactiveFormsModule } from "@angular/forms";
import { ToastModule } from "primeng/toast";


@NgModule({
  declarations: [
    LoginComponent,
    RegisterComponent
  ],
    imports: [
        CommonModule,
        AuthRoutingModule,
        InputTextModule,
        ButtonModule,
        RippleModule,
        ReactiveFormsModule,
        ToastModule
    ]
})
export class AuthModule { }
