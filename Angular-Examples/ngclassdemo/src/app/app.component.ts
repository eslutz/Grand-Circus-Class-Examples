import { Component } from '@angular/core';
import { Person } from './interface/person';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = "ngclassdemo";
  newName = "";

  isItalic = false;
  isGreen = true;
  isHidden = false;
  theColor = "blue";

  doClick() {
    this.isItalic = !this.isItalic;
    this.isGreen = !this.isGreen;
    this.theColor = "red";
  }

  doHide() {
    this.isHidden = !this.isHidden;
  }

  updateName(p: Person) {
    this.newName = `${p.firstName} ${p.lastName}`;
  }
}