import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import {HttpClientModule} from '@angular/common/http';
// 3rd party libiary

import {
  NgbCarouselModule,
  NgbCollapseModule,
  NgbDropdownModule,
  NgbModalModule,
  NgbPaginationModule,
  NgbTabsetModule,
  NgbAlertModule
} from "@ng-bootstrap/ng-bootstrap";

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { GenresComponent } from './genres/genres.component';
import { HeaderComponent } from './core/layout/header.component';
import { LoginComponent } from './auth/login/login.component';
import { SignUpComponent } from './auth/sign-up/sign-up.component';
import { MovieDetailsComponent } from './movies/movie-details/movie-details.component';
import { MovieCardComponent } from './shared/components/movie-card/movie-card.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MovieListComponent } from './movies/movie-list/movie-list.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { FavoritesComponent } from './account/favorites/favorites.component';
import { PurchasesComponent } from './account/purchases/purchases.component';
import { ProfileComponent } from './account/profile/profile.component';
import { OverviewPipe } from './pipes/overview.pipe';



//decorators are like attributes in c# []
@NgModule({
  //components, if we want to use component in Angular they should be declared inside atleast one model
  
  declarations: [
    AppComponent,
    HomeComponent,
    GenresComponent,
    HeaderComponent,
    LoginComponent,
    SignUpComponent,
    MovieDetailsComponent,
    MovieCardComponent,
    MovieListComponent,
    FavoritesComponent,
    PurchasesComponent,
    ProfileComponent,
    OverviewPipe,
 

  ],
//third party compotent
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule,
    NgbCarouselModule,
    NgbCollapseModule,
    NgbDropdownModule,
    NgbModalModule,
    NgbPaginationModule,
    NgbTabsetModule,
    NgbAlertModule,
    FormsModule,
    ReactiveFormsModule,
  ],
//dependency injection 
  providers: [],

  //we can select which component needs to be started when app  start
  //main-->AppModule-->bootstrap AppComponent
  bootstrap: [AppComponent]
})
//if we delete the code above, it's just a normal class 
//like controller in mvc need to inhertnte the controller class
export class AppModule { }
