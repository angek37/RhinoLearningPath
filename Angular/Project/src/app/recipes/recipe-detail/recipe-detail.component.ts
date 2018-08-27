import {Component, OnInit} from '@angular/core';
import {Recipe} from '../recipe.model';
import {ShoppingListService} from '../../shopping-list/shopping-list.service';
import {ActivatedRoute, Params, Router, RouterModule} from '@angular/router';
import {RecipeService} from '../recipe.service';

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
              private router: Router) { }

  ngOnInit() {
    this.activeRoute.params
      .subscribe(
        (params: Params) => {
          this.recipe = this.recipeService.getRecipe(+params['id']);
        }
      );
  }

  sendToList() {
    for (const ingredient of this.recipe.ingredients) {
      this.shoppingList.addIngredient(ingredient);
    }
  }

  deleteRecipe() {
    this.recipeService.deleteRecipe(this.recipe.id);
    this.router.navigate(['recipes']);
  }

}
