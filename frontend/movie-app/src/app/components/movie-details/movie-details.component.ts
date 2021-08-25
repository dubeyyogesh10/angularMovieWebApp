import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Subscription } from 'rxjs';
import { Movie } from 'src/app/models/movie.model';
import { MovieServiceService } from 'src/app/service/movie-service.service';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css'],
})
export class MovieDetailsComponent implements OnInit {
  routeParam: Subscription = new Subscription();
  movieId = '';
  movie: Movie;
  constructor(
    private activatedRoute: ActivatedRoute,
    public service: MovieServiceService
  ) {}

  ngOnInit(): void {
    this.routeParam = this.activatedRoute.params.subscribe((params: Params) => {
      this.movieId = params.id;
      this.getmovieDetails(this.movieId);
    });
  }

  getmovieDetails = (id: string): void => {
    console.log('getting details ---' + this.service.getMovie(id));
    this.movie = this.service.getMovie(id)!;
  };
}
