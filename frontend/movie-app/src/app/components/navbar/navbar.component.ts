import { Component, OnInit } from '@angular/core';
import { MovieServiceService } from 'src/app/service/movie-service.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})
export class NavbarComponent implements OnInit {
  serachvalue = '';
  constructor(private service: MovieServiceService) {}

  ngOnInit(): void {}

  OnSearch = () => {
    const filterMovies = this.service.movieList.filter((x) =>
      x.Title.toLowerCase().includes(this.serachvalue.toLowerCase())
    );

    this.service.AddMovieToSharedList(filterMovies);
  };
}
