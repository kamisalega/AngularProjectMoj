import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {Error404Component} from "./shared/component/error404/error404.component";
import {LibraryListComponentComponent} from "./shared/component/library-list-component/library-list-component.component";


const appRoutingModule: Routes = [
  {path: 'library', component: LibraryListComponentComponent},
  {path: '404', component: Error404Component},
  {path: 'user', loadChildren: './user/user.module#UserModule'},
  {path: '', redirectTo: '/library', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutingModule)],
  exports: [RouterModule]
})
export class AppRoutingModule  {

}


