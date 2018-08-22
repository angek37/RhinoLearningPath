import {Component, Input, OnInit} from '@angular/core';
import {Recipe} from '../recipe.model';
import {ShoppingListService} from '../../shopping-list/shopping-list.service';
import {forEach} from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit {
  @Input() recipe: Recipe;

  constructor(private shoppingList: ShoppingListService) { }

  ngOnInit() {
  }

  sendToList() {
    for (const ingredient of this.recipe.ingredients) {
      this.shoppingList.addIngredient(ingredient);
    }
  }

}
