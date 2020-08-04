import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root',
})
export class ApiService {
  private headers :HttpHeaders;
  // private readon.....
  constructor(protected http: HttpClient) {
    

  }
  // get movies by genre
  // get all genres
  // get movies purchased by user
  // http://localhost:58601/api/genres
  // rxjs library 
  // publish/subscribe
  // news letters...we subscribe to those news letter, whenevr there is a brreaing news we get notofication
  // we make an Http call, but that http call will only be made and will only rcieve data when you subscibe
  // Observales can be finite or infinite
  // http call is a finite observable.
  // 
  getAll(path: string): Observable<any[]> {
    // we need to append the common url with path that is being passed
    // map is same as select in C# LINQ
    // 1,2,3 select map (n => n*n) = 1, 4 9
    // 1,2,3 where , filter ( n => n> 2) = 3
    return this.http.get(`${environment.apiUrl}${path}`)
      .pipe(
        map((resp) => resp as any[])
        );
  }
  // get movie by movie id
  // get userinfo by id
  // http://localhost:58601/api/movies/1
  getOne(path: string, id?: number, queryParams?: Map<any, any>): Observable<any> {
    let getUrl: string;
    if (id) {
      getUrl = `${environment.apiUrl}${path}` + '/' + id;
    } else {
      getUrl = `${environment.apiUrl}${path}`;
    }

    let params = new HttpParams();
    if (queryParams) {
      queryParams.forEach((value: string, key: string) => {
        params = params.append(key, value);
      });
    }

    return this.http.get(getUrl, { params }).pipe(
      map(resp => resp as any)
      
    );
  }
  // post some information
  // login, signup, create movie
  create(path: string, resource, options?): Observable<any> {
    return this.http
      .post(`${environment.apiUrl}${path}`, resource, { headers: this.headers })
      .pipe(
        map(response => response),
        // catchError(this.handleError)
      );
  }
  // updateb movie info
  //update user info
  update() {}
  // delete favorite movie
  delete(path: string, id) {
    return this.http.delete(`${environment.apiUrl}${path}` + '/' + id).pipe(
      map(response => response),
      // catchError(this.handleError)
    );
  }
}