import { Component, OnInit } from '@angular/core';
import {Ingredient} from '../shared/ingredient.model';
import {ShoppingListService} from './shopping-list.service';
import {Store} from '@ngrx/store';
import {Observable} from 'rxjs';
import * as fromShoppingList from './store/shopping-list.reducers';
import * as ShoppingListActions from './store/shopping-list.actions';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css']
})
export class ShoppingListComponent implements OnInit {
  shoppingList: Observable<{ingredients: Ingredient[]}>;

  constructor(private slSvc: ShoppingListService, private store: Store<fromShoppingList.State>) { }

  ngOnInit() {
    this.shoppingList = this.store.select('shoppingList');
  }

  onEditItem(index: number) {
    this.store.dispatch(new ShoppingListActions.StartEdit(index));
  }
}
