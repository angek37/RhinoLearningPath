import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {HomeComponent} from './home/home.component';
import {TokenComponent} from './token/token.component';
import {TokensComponent} from './tokens/tokens.component';

const routes: Routes = [
  {path: '', component: HomeComponent },
  {path: 'token', component: TokensComponent, children: [
      {path: ':id', component: TokenComponent}
    ]}
];
@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
