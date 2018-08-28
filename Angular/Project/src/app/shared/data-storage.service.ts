import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {RecipeService} from '../recipes/recipe.service';
import {Recipe} from '../recipes/recipe.model';

@Injectable()
export class DataStorageService {
  constructor(private http: Http, private recipesService: RecipeService) {}

  storeRecipes(): any {
    return this.http.put('https://ng-recipe-book-b4515.firebaseio.com/recipes.json',
      this.recipesService.getRecipes());
  }

  fetchRecipes(): any {
    this.http.get('https://ng-recipe-book-b4515.firebaseio.com/recipes.json')
      .subscribe(
        (response: Response) => {
          const recipes: Recipe[] = response.json();
          this.recipesService.setRecipes(recipes);
        }
      );
  }
}
