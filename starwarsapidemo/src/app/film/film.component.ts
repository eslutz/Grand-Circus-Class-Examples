import { Component, Input, OnInit } from '@angular/core';
import { Film } from '../interfaces/film';
import { StarWarsService } from '../star-wars.service';

@Component({
  selector: 'app-film',
  templateUrl: './film.component.html',
  styleUrls: ['./film.component.css']
})
export class FilmComponent implements OnInit {
@Input() url: string;
film: Film;
  constructor(private swService: StarWarsService) { }

  ngOnInit(): void {
    this.swService.getFilm(this.url).subscribe((data: Film) => this.film = data);
  }
}
