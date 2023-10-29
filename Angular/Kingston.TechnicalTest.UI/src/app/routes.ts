import { Routes } from '@angular/router'
import { DashboardComponent } from './dashboard/dashboard.component';

export const appRoutes: Routes = [
    { path: 'Dashboard', component: DashboardComponent },
    { path : '', redirectTo:'/Dashboard', pathMatch : 'full'},
];