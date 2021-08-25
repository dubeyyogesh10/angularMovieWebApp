import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Movie } from '../models/movie.model';
import * as data from './../../assets/movies.json';

@Injectable({
  providedIn: 'root',
})
export class MovieServiceService {
  movieList: Movie[] = [];
  constructor(private httpClient: HttpClient) {}

  getMovieDetails = (): Movie[] => {
    this.movieList = data.movies as Movie[];
    console.log(this.movieList);
    return this.movieList;
  };

  getMovie = (id: string): Movie => {
    this.movieList = data.movies as Movie[];
    console.log(this.movieList);
    //let movie: Movie = {};
    let movie = this.movieList.find((x) => x.imdbID === id)!;
    console.log(movie);
    return movie;
  };
}
