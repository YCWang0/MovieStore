import { User } from './../../shared/models/user';
import { UserService } from './../../core/services/user.service';
import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/shared/models/movie';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-purchases',
  templateUrl: './purchases.component.html',
  styleUrls: ['./purchases.component.css']
})
export class PurchasesComponent implements OnInit {
  movies:Movie[];
  id:number;
  constructor(private UserService:UserService,private route: ActivatedRoute) { }

  ngOnInit(): void {

    this.route.paramMap.subscribe(
      params=>{
        this.id=+params.get('id');
        this.getAllPurchases();
        
      }
    );

 }

    private getAllPurchases(){
      this.UserService.getPurchasedMovies(this.id).subscribe((m)=>{
        this.movies=m;
      });
    }

}
