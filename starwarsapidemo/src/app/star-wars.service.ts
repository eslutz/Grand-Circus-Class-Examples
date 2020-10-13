import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { People } from './interfaces/people';
import { Planet } from './interfaces/planet';
import { Film } from './interfaces/film';

@Injectable({
  providedIn: 'root'
})
export class StarWarsService {

  constructor(private http:HttpClient) { }

  getPeople() {
    return this.http.get<People>('https://swapi.dev/api/people/');
  }

  getPlanet(url: string) {
    return this.http.get<Planet>(url);
  }

  getFilm(url: string) {
    return this.http.get<Film>(url);
  }
}