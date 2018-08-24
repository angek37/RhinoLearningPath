import {Ingredient} from '../shared/ingredient.model';

export class Recipe {
  public id: number;
  public name: string;
  public description: string;
  public imagePath: string;
  public ingredients: Ingredient[];

  constructor(id: number, name: string, descr: string, imagePath: string, ingredients: Ingredient[]) {
    this.id = id;
    this.name = name;
    this.description = descr;
    this.imagePath = imagePath;
    this.ingredients = ingredients;
  }
}
