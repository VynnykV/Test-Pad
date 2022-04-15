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
import { TestPageComponent } from './test-page/test-page.component';
import { DataViewModule } from "primeng/dataview";
import { ScrollingModule } from "@angular/cdk/scrolling";
import { PaginatorModule } from "primeng/paginator";
import { BadgeModule } from "primeng/badge";
import { ChipModule } from "primeng/chip";
import { SelectButtonModule } from "primeng/selectbutton";
import { AvatarModule } from "primeng/avatar";
import { RadioButtonModule } from "primeng/radiobutton";
import { TestResultComponent } from './test-page/test-result/test-result.component';


@NgModule({
    declarations: [
        MainPageComponent,
        HomePageComponent,
        TestsPageComponent,
        TestPageComponent,
        TestResultComponent
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
        CheckboxModule,
        DataViewModule,
        ScrollingModule,
        PaginatorModule,
        BadgeModule,
        ChipModule,
        SelectButtonModule,
        AvatarModule,
        RadioButtonModule
    ]
})
export class MainModule { }
