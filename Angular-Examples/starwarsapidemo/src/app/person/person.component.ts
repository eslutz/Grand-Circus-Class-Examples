import { Component, Input, OnInit } from '@angular/core';
import { Person } from '../interfaces/people';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {
  @Input() currentPerson: Person;
  constructor() { }

  ngOnInit(): void {
  }

}
