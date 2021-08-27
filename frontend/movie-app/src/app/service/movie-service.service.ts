import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Movie } from '../models/movie.model';

@Injectable({
  providedIn: 'root',
})
export class MovieServiceService {
  serviceMovieList: Movie[] = [];
  private sharedMovieList = new BehaviorSubject<Movie[]>(null);
  readonly baseUrl = 'http://localhost:5000/api/Movie';

  constructor(private httpClient: HttpClient) {}

  getMovieDetails = (): Movie[] => {
    return this.serviceMovieList;
  };

  getMovie = (id: string): Movie => {
    // let movie: Movie = {};
    const movie = this.serviceMovieList.find((x) => x.imdbID == id);
    console.log(movie);
    return movie;
  };

  getMoviesFromApi = (): void => {
    this.httpClient.get<Movie[]>(this.baseUrl).subscribe((res) => {
      this.serviceMovieList = res as Movie[];
      this.AddMovieToSharedList(this.serviceMovieList);
    });
  };

  AddMovieToSharedList = (movies: Movie[]) => {
    console.log('data loaded for behaviour subjtec ' + movies.length);
    this.sharedMovieList.next(movies);
  };

  getSharedMovieList = (): Observable<Movie[]> => {
    return this.sharedMovieList.asObservable();
  };
}
