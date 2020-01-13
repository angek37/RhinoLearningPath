import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {BrowserXhr, HttpModule} from '@angular/http';
import {StoreModule} from '@ngrx/store';

import {AppComponent} from './app.component';
import {AppRoutingModule} from './app-routing.module';
import {SharedModule} from './shared/shared.module';
import {AuthModule} from './auth/auth.module';
import {NgProgressBrowserXhr, NgProgressModule} from 'ngx-progressbar';
import {CoreModule} from './core/core.module';
import {shoppingListReducer} from './shopping-list/store/shopping-list.reducers';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    AuthModule,
    SharedModule,
    AppRoutingModule,
    NgProgressModule,
    CoreModule,
    StoreModule.forRoot({shoppingList: shoppingListReducer})
  ],
  providers: [{provide: BrowserXhr, useClass: NgProgressBrowserXhr}],
  bootstrap: [AppComponent]
})
export class AppModule { }
