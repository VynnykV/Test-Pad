import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TestsPageComponent } from "./tests-page/tests-page.component";
import { TestPageComponent } from "./test-page/test-page.component";

const routes: Routes = [
    {
        path: 'tests',
        component: TestsPageComponent
    },
    {
        path: 'test/:id',
        component: TestPageComponent
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MainRoutingModule { }
