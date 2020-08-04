import { ActivatedRoute } from '@angular/router';
import { UserService } from './../../core/services/user.service';
import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/shared/models/movie';

@Component({
  selector: 'app-favorites',
  templateUrl: './favorites.component.html',
  styleUrls: ['./favorites.component.css']
})
export class FavoritesComponent implements OnInit {
  movies:Movie[];
  id:number;
  constructor(private UserService:UserService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(
      params=>{
        this.id =+params.get('id');
        this.getAllFavorites();
      }
    );
  }
  private getAllFavorites(){
    this.UserService.getfavoritedMovies(this.id).subscribe((m)=>{
      this.movies= m;
    });
  }

}
