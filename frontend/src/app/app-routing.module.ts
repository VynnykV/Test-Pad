import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from "./core/guards/auth.guard";

const routes: Routes = [
    {
        path: '',
        redirectTo: '/main/tests',
        pathMatch: 'full'
    },
    {
        path: 'main',
        loadChildren: () =>
            import('./modules/main/main.module')
                .then(m => m.MainModule),
        canActivate: [AuthGuard]
    },
    {
        path: 'home',
        loadChildren: () =>
            import('./modules/home/home.module')
                .then(m => m.HomeModule)
    },
    {
        path: '',
        loadChildren: () =>
            import('./modules/auth/auth.module')
                .then(m => m.AuthModule)
    }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
