import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MainRoutingModule } from './main-routing.module';
import { MainPageComponent } from './main-page/main-page.component';
import { MenubarModule } from "primeng/menubar";
import { ButtonModule } from "primeng/button";
import { SharedModule } from "primeng/api";
import { HomePageComponent } from './home/home-page.component';
import { CardModule } from "primeng/card";
import { ToastModule } from "primeng/toast";


@NgModule({
    declarations: [
        MainPageComponent,
        HomePageComponent
    ],
    exports: [
        MainPageComponent
    ],
    imports: [
        CommonModule,
        MainRoutingModule,
        MenubarModule,
        ButtonModule,
        SharedModule,
        CardModule,
        ToastModule
    ]
})
export class MainModule { }
