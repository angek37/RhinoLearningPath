import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {RecipeService} from '../recipes/recipe.service';
import {Recipe} from '../recipes/recipe.model';
import {Body} from '@angular/http/src/body';
import {AuthService} from '../auth/auth.service';

@Injectable()
export class DataStorageService {
  constructor(private http: Http,
              private recipesService: RecipeService,
              private authService: AuthService) {}

  storeRecipes(): any {
    const token = this.authService.getToken();
    return this.http.put('https://ng-recipe-book-b4515.firebaseio.com/recipes.json?auth=' + token,
      this.recipesService.getRecipes());
  }

  fetchRecipes(): any {
    const token = this.authService.getToken();
    this.http.get('https://ng-recipe-book-b4515.firebaseio.com/recipes.json?auth=' + token)
      .subscribe(
        (response: Body) => {
          const recipes: Recipe[] = response.json();
          this.recipesService.setRecipes(recipes);
          return;
        }
      );
  }
}
