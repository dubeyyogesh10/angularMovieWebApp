import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MovieViewListComponent } from './components/movie-view-list/movie-view-list.component';
import { Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: AppComponent,
  },
  {
    path: 'movie-details',
    component: MovieViewListComponent,
  },
];

@NgModule({
  declarations: [AppComponent, NavbarComponent, MovieViewListComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
