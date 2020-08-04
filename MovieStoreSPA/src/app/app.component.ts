import { Component } from '@angular/core';

//declar it's a component
@Component({
  //selector means we can select things to use like partiall view 
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MovieStoreSPA';
}
