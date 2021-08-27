import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Movie } from '../models/movie.model';
import * as data from './../../assets/movies.json';

@Injectable({
  providedIn: 'root',
})
export class MovieServiceService {
  movieList: Movie[] = [];
  private sharedMovieList = new BehaviorSubject<Movie[]>(null);
  constructor(private httpClient: HttpClient) {}

  getMovieDetails = (): Movie[] => {
    this.movieList = data.movies as Movie[];
    this.AddMovieToSharedList(this.movieList);
    console.log(this.movieList);
    return this.movieList;
  };

  getMovie = (id: string): Movie => {
    this.movieList = data.movies as Movie[];
    console.log(this.movieList);
    let movie = this.movieList.find((x) => x.imdbID === id)!;
    console.log(movie);
    return movie;
  };

  AddMovieToSharedList = (movies: Movie[]) => {
    this.sharedMovieList.next(movies);
  };

  getSharedMovieList = (): Observable<Movie[]> => {
    return this.sharedMovieList.asObservable();
  };
}
