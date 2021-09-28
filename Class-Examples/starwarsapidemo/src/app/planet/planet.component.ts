import { Component, Input, OnInit } from '@angular/core';
import { Planet } from '../interfaces/planet';
import { StarWarsService } from '../star-wars.service';

@Component({
  selector: 'app-planet',
  templateUrl: './planet.component.html',
  styleUrls: ['./planet.component.css']
})
export class PlanetComponent implements OnInit {
  @Input() url: string;
  planet: Planet;
  constructor(private swService: StarWarsService) { }

  ngOnInit(): void {
    this.swService.getPlanet(this.url).subscribe((data: Planet) => this.planet = data);
  }

}