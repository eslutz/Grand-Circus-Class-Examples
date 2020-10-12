import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-new-comp',
  templateUrl: './new-comp.component.html',
  styleUrls: ['./new-comp.component.css']
})
export class NewCompComponent implements OnInit {
  @Input() header = "Greetings";
  @Output() callParent = new EventEmitter<string>();
  firstName = "Hi";
  lastName = "There";
  constructor() { }

  ngOnInit(): void {
  }

  clickResult() {
    //alert(`Welcome ${this.firstName} ${this.lastName}`);
    this.callParent.emit(`${this.firstName} ${this.lastName}`);
  }

  clickTest() {
    this.firstName = "Enter first name!";
    this.lastName = "Enter last name!";
  }
}
