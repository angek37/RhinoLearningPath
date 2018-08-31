import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';

import {ShoppingListRoutingModule} from './shoppinglist-routing.module';
import {ShoppingListComponent} from './shopping-list.component';
import {ShoppingEditComponent} from './shopping-edit/shopping-edit.component';
import {SharedModule} from '../shared/shared.module';

@NgModule({
  declarations: [
    ShoppingListComponent,
    ShoppingEditComponent
  ],
  imports: [
    SharedModule,
    CommonModule,
    ShoppingListRoutingModule
  ]
})
export class ShoppingListModule {}
