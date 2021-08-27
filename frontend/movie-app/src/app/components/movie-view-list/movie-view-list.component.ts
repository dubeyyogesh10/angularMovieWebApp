import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Movie } from 'src/app/models/movie.model';
import { MovieServiceService } from 'src/app/service/movie-service.service';
@Component({
  selector: 'app-movie-view-list',
  templateUrl: './movie-view-list.component.html',
  styleUrls: ['./movie-view-list.component.css'],
})
export class MovieViewListComponent implements OnInit {
  constructor(private router: Router, private service: MovieServiceService) {}
  movieList: Movie[] = [];
  ngOnInit(): void {
    this.service.getMoviesFromApi();
    this.loadTempData();
  }

  loadTempData = () => {
    this.service.getSharedMovieList().subscribe(
      (res) => {
        this.movieList = res as Movie[];
        console.log('service movielist ' + this.service.serviceMovieList);
      },
      (err) => {
        console.log('Error -> ' + err);
      }
    );
    console.log(this.movieList);
  };

  getMovieDetails = (id: string) => {
    this.router.navigate(['details', id]);
  };
}
