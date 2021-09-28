import { Component, OnInit } from '@angular/core';
import { People } from '../interfaces/people';
import { StarWarsService } from '../star-wars.service';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {
  people: People;
  constructor(private swService: StarWarsService) { }

  ngOnInit(): void {
    // this.swService.getPeople().subscribe(
    //   function(data: People) {
    //     this.people = data;
    //   }
    // );
    this.swService.getPeople().subscribe((data: People) => this.people = data);
  }

}
