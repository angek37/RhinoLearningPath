import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {CrmService} from './crm/crm.service';
import {HttpClientModule} from '@angular/common/http';
import {MsAdalAngular6Module} from 'microsoft-adal-angular6';
import {environment} from '../environments/environment';
import { HomeComponent } from './home/home.component';
import { TokenComponent } from './token/token.component';
import {AppRoutingModule} from './app-routing.module';
import { NgProgressModule } from '@ngx-progressbar/core';
import { NgProgressHttpModule } from '@ngx-progressbar/http';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TokenComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    MsAdalAngular6Module.forRoot(environment.ad),
    NgProgressModule.forRoot(),
    NgProgressHttpModule
  ],
  providers: [CrmService],
  bootstrap: [AppComponent]
})
export class AppModule { }
