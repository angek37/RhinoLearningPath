import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Params, Router} from '@angular/router';
import {Store} from '@ngrx/store';
import {Recipe} from '../recipe.model';
import {ShoppingListService} from '../../shopping-list/shopping-list.service';
import {RecipeService} from '../recipe.service';
import * as ShoppingList from '../../shopping-list/store/shopping-list.actions';
import * as fromShoppingList from '../../shopping-list/store/shopping-list.reducers';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit {
  recipe: Recipe;

  constructor(private recipeService: RecipeService,
              private shoppingList: ShoppingListService,
              private activeRoute: ActivatedRoute,
              private router: Router,
              private store: Store<fromShoppingList.State>) { }

  ngOnInit() {
    this.activeRoute.params
      .subscribe(
        (params: Params) => {
          this.recipe = this.recipeService.getRecipe(+params['id']);
        }
      );
  }

  sendToList() {
    this.store.dispatch(new ShoppingList.AddIngredients(this.recipe.ingredients));
  }

  deleteRecipe() {
    this.recipeService.deleteRecipe(this.recipe.id);
    this.router.navigate(['recipes']);
  }

}
