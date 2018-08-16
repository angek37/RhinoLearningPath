import { Component, OnInit } from '@angular/core';
import {Recipe} from '../recipe.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent implements OnInit {
  recipes: Recipe[] = [
    new Recipe('A Test Recipe', 'This is a simply a test',
      'https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F' +
      '%2Fimg1.southernliving.timeinc.net%2Fsites%2Fdefault%2Ffiles%2Fstyles%2' +
      'Fmedium_2x%2Fpublic%2Fimage%2F2018%2F02%2Fmain%2F2548601_qfsba_rice_with_scallops_152.jpg%3Fitok%3Dqvkz_lUq&w=700&q=85'),
    new Recipe('A Test Recipe 2', 'This is a simply a test',
      'https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2F' +
      'files%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2F11%2F04%2Ffettuccine-olive-oil-ck-x.jpg%3Fitok%3Dbt5Cny7R&w=800&q=85')
  ];

  constructor() { }

  ngOnInit() {
  }

}
