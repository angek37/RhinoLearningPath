import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';

import {RecipeStartComponent} from './recipe-detail/recipe-start/recipe-start.component';
import {RecipesComponent} from './recipes.component';
import {RecipeEditComponent} from './recipe-edit/recipe-edit.component';
import {RecipeDetailComponent} from './recipe-detail/recipe-detail.component';
import {AuthGuard} from '../auth/auth-guard.service';

const recipesRoutes: Routes = [
  {path: '', component: RecipesComponent, children: [
      {path: '', component: RecipeStartComponent},
      {path: 'new', component: RecipeEditComponent, canActivate: [AuthGuard]},
      {path: ':id', component: RecipeDetailComponent},
      {path: ':id/edit', component: RecipeEditComponent, canActivate: [AuthGuard]}
    ]}
];

@NgModule({
  imports: [
    RouterModule.forChild(recipesRoutes)
  ],
  exports: [RouterModule],
  providers: [AuthGuard]
})
export class RecipesRoutingModule { }
