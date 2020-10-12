import { Component } from '@angular/core';

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

  updateName(str: string) {
    this.newName = str;
  }
}