import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/movie.model';
import * as data from './../../../assets/movies.json';

@Component({
  selector: 'app-movie-view-list',
  templateUrl: './movie-view-list.component.html',
  styleUrls: ['./movie-view-list.component.css'],
})
export class MovieViewListComponent implements OnInit {
  constructor() {}
  movieList: Movie[] = [];
  ngOnInit(): void {
    this.loadTempData();
  }

  loadTempData = () => {
    this.movieList = data.movies as Movie[];
    console.log(this.movieList);
    console.log(data);
  };

  getMovieDetails = (imdbID: string) => {
    console.log(imdbID);
  };
}
