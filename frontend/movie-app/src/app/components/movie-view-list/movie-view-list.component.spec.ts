import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MovieViewListComponent } from './movie-view-list.component';

describe('MovieViewListComponent', () => {
  let component: MovieViewListComponent;
  let fixture: ComponentFixture<MovieViewListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MovieViewListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MovieViewListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
