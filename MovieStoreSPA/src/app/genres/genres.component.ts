import { Genre } from './../shared/models/genre';
import { GenreService } from './../core/services/genre.service';
import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-genres',
  templateUrl: './genres.component.html',
  styleUrls: ['./genres.component.css']
})
export class GenresComponent implements OnInit {
  genres: Genre[];
  constructor(private genreServce:GenreService) { }
  // Page Life Cycle Hooks
  // alt +shift+f
  //alt+O from angular switch extension
  ngOnInit(){
    // we wanna initialize any data, call the APi etc
    this.genreServce.getAllGenres()
    .subscribe( g => {
      this.genres = g;
      console.log('inside Genres Component init method');
      console.log(this.genres);
      
    } )
  }
}