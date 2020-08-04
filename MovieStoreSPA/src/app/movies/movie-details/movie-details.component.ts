import { UserService } from './../../core/services/user.service';
import { MovieService } from './../../core/services/movie.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/shared/models/movie';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {
  movie:Movie;
  id:number;
  isAuthenticated = false;
  currentMoviePurchased = false;
  currentMovieFavorited = false;

  constructor(private movieService: MovieService, private userService: UserService, private route: ActivatedRoute, 
    // tslint:disable-next-line: align
    private router: Router, private modalService: NgbModal) { }

  ngOnInit() {
    // this.authService.isAuthenticated.subscribe(isAuthenticated => {
    //   this.isAuthenticated = isAuthenticated;
    // });
    // console.log('Movie is purchased', this.currentMoviePurchased);

    this.route.paramMap.subscribe(
      params => {
        this.id = +params.get('id');
        this.getMovieDetails();
        console.log("current movie id is "+this.id)
      }
    );
  }

  private getMovieDetails() {
    this.movieService.getMovieDetails(this.id)
      .subscribe(m => {
        this.movie = m;
        // if (this.isAuthenticated) {
        //   this.isCurrentMoviePurchased();
        //   this.isMovieFavorited();
        // }

      });
      console.log("current movie is " + this.movie)
  }

  // buyMovie(movie: Movie) {
  //   if (this.isAuthenticated) {
  //     const modalRef = this.modalService.open(MoviePurchaseConfirmComponent);
  //     modalRef.componentInstance.movie = movie;
  //   } else {
  //     this.router.navigateByUrl('/login');
  //   }

  // }


  // onToggleFavorite(favorited: boolean) {
  //   this.isMovieFavorited();
  // }
  // private isCurrentMoviePurchased(): void {

  //   this.currentMoviePurchased = false;

  //   if (this.movie) {
  //     this.userDataService.purchasedMovies.subscribe(
  //       pm => {
  //         // console.log('inside purchased movies subscription of movie details');
  //         this.currentMoviePurchased = (pm.purchasedMovies.some(p => p.id === this.movie.id));

  //       }

  //     );

  //   }
  // }

  // private isMovieFavorited(): void {
  //   this.currentMovieFavorited = false;
  //   if (this.movie) {
  //     this.userService.isMovieFavorited(this.authService.getCurrentUser().nameid, this.id).subscribe(
  //       f => {
  //         this.currentMovieFavorited = f.isFavorited;
  //       }
  //     );

  //   }

  // }

}
