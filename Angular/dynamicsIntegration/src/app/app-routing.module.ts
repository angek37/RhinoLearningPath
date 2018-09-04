import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {HomeComponent} from './home/home.component';
import {TokenComponent} from './token/token.component';

const routes: Routes = [
  {path: '', component: HomeComponent },
  {path: 'token/:id', component: TokenComponent}
];
@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
