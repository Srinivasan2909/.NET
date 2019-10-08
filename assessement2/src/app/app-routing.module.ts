import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {AppComponent} from './app.component';
import {CreateComponent} from './create/create.component';
import {DepinfoComponent} from './depinfo/depinfo.component';


const routes: Routes = [{path:'',component:AppComponent},
{  path:'list',component:DepinfoComponent},
{path:'create',component:CreateComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
