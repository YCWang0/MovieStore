import { ApiService } from './api.service';
import { Injectable } from '@angular/core';
import { Purchase } from 'src/app/shared/models/purchase';
import { Observable } from 'rxjs';
import { Purchases } from 'src/app/shared/models/purchases';
import { Favorite } from 'src/app/shared/models/favorite';
import { Movie } from 'src/app/shared/models/movie';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private ApiService:ApiService) { }

  purchaseMovie(purchase: Purchase) {
    return this.ApiService.create('user/purchase', purchase);
  }

  getPurchasedMovies(id: number): Observable<Movie[]> {
    return this.ApiService.getAll(`${'user/'}${'purchases/'}${id}`);
  }
  favoriteMovie(favorite: Favorite) {
    return this.ApiService.create('user/favorite', favorite);
  }
  unfavoriteMovie(favorite: Favorite) {
    return this.ApiService.create('user/unfavorite', favorite);
  }
  isMovieFavorited(userId: number, movieId: number): Observable<any> {
    return this.ApiService.getOne(`${'user/'}${userId}/movie/${movieId}${'/favorite'}`);
  }
 getfavoritedMovies(id:number):Observable<Movie[]>{
  return this.ApiService.getAll(`${'user/'}${'favorites/'}${id}`);
 }
}
