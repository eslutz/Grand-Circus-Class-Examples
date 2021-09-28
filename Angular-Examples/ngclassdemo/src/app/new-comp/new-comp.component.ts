import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Person } from '../interface/person';

@Component({
  selector: 'app-new-comp',
  templateUrl: './new-comp.component.html',
  styleUrls: ['./new-comp.component.css']
})
export class NewCompComponent implements OnInit {
  @Input() header = "Greetings";
  @Output() callParent = new EventEmitter<Person>();
  firstName = "Hi";
  lastName = "There";
  constructor() { }

  ngOnInit(): void {
  }

  clickResult() {
    //alert(`Welcome ${this.firstName} ${this.lastName}`);
    let p: Person = {firstName: this.firstName, lastName: this.lastName}
    this.callParent.emit(p);
  }

  clickTest() {
    this.firstName = "Enter first name!";
    this.lastName = "Enter last name!";
  }
}
