import { Injectable } from '@angular/core';
import { ApiService } from './api.service'
@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private apiService: ApiService) { }

  getAllGenres(){
    //http://localhost:5801/api/genres 不想每次都 输入那么多 去environment
    return this.apiService.getAll('genres');
  }

}
