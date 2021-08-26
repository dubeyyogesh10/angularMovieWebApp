import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Movie } from '../models/movie.model';

@Injectable({
  providedIn: 'root',
})
export class MovieServiceService {
  movieList: Movie[] = [];
  readonly baseUrl = 'http://localhost:5000/api/Movie';

  constructor(private httpClient: HttpClient) {
    this.getMoviesFromApi();
  }

  getMovieDetails = (): Movie[] => {
    console.log(this.movieList);
    return this.movieList;
  };

  getMovie = (id: string): Movie => {
    console.log('get ovie by id' + this.movieList);
    // let movie: Movie = {};
    const movie = this.movieList.find((x) => x.imdbID == id);
    console.log(movie);
    return movie;
  };

  getMoviesFromApi = () => {
    return this.httpClient.get<Movie[]>(this.baseUrl);
  };
}
