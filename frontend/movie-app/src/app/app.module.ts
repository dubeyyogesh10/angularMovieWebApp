import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MovieViewListComponent } from './components/movie-view-list/movie-view-list.component';
import { Router, RouterModule, Routes } from '@angular/router';
import { MovieDetailsComponent } from './components/movie-details/movie-details.component';

const routes: Routes = [
  {
    path: 'details/:id',
    component: MovieDetailsComponent,
  },
  {
    path: 'home',
    component: MovieViewListComponent,
  },
  {
    path: '',
    component: MovieViewListComponent,
  },
];

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    MovieViewListComponent,
    MovieDetailsComponent,
  ],
  imports: [BrowserModule, RouterModule.forRoot(routes), HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
