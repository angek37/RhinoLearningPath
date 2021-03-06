import {Component, OnDestroy, OnInit} from '@angular/core';
import {Recipe} from '../recipe.model';
import {RecipeService} from '../recipe.service';
import {Subscription} from 'rxjs';
import {faFileAlt} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent implements OnInit, OnDestroy {
  newIcon = faFileAlt;
  recipes: Recipe[];
  suscription: Subscription;

  constructor(private recipeService: RecipeService) { }

  ngOnInit() {
    this.suscription = this.recipeService.recipesChanged
      .subscribe(
        (recipes: Recipe[]) => {
          this.recipes = recipes;
        }
      );
    this.recipes = this.recipeService.getRecipes();
  }

  ngOnDestroy(): void {
    this.suscription.unsubscribe();
  }
}
