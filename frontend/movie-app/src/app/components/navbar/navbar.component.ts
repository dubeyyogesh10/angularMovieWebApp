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
    console.log('inside search ' + this.serachvalue);
    let test = this.service.movieList.filter((x) =>
      x.title.includes(this.serachvalue)
    );

    test.forEach((i) => {
      console.log('inside print  ' + i.title + test.length);
    });
  };
}
