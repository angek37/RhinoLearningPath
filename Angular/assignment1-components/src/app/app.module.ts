import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import {SuccessComponent} from './Success/success.component';
import {WarningComponent} from './Warning/warning.component';
import {DatabindingComponent} from './Databinding/databinding.component';
import {DirectivesComponent} from './Directives/directives.component';

@NgModule({
  declarations: [
    AppComponent,
    SuccessComponent,
    WarningComponent,
    DatabindingComponent,
    DirectivesComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
