import { PurchasesComponent } from './account/purchases/purchases.component';
import { ProfileComponent } from './account/profile/profile.component';
import { FavoritesComponent } from './account/favorites/favorites.component';
import { Favorite } from './shared/models/favorite';
import { MovieListComponent } from './movies/movie-list/movie-list.component';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './auth/login/login.component';
import { SignUpComponent } from './auth/sign-up/sign-up.component';
import { MovieDetailsComponent } from './movies/movie-details/movie-details.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'login',component:LoginComponent},
  {path:'signup',component:SignUpComponent},
  {path:'movie/:id',component:MovieDetailsComponent},
  {path:'movies/genre/:id',component:MovieListComponent},
  {path:'movies/:id',component:MovieDetailsComponent},
  {path:'account/favorites/:id',component:FavoritesComponent},
  {path:'account/profile',component:ProfileComponent},
  {path:'account/purchases/:id',component:PurchasesComponent},
  {path:'account/favorites/:id',component:FavoritesComponent}
];
//front end url compone navgaration
//call api url in service 

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
