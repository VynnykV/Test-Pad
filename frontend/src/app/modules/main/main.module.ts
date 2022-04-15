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
import { TestsPageComponent } from './tests-page/tests-page.component';
import { ConfirmDialogModule } from "primeng/confirmdialog";
import { CheckboxModule } from "primeng/checkbox";


@NgModule({
    declarations: [
        MainPageComponent,
        HomePageComponent,
        TestsPageComponent
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
        ToastModule,
        ConfirmDialogModule,
        CheckboxModule
    ]
})
export class MainModule { }
