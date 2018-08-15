import { Component } from '@angular/core';

@Component({
  selector: 'app-directives',
  templateUrl: './directives.component.html',
  styleUrls: ['./directives.component.css']
})
export class DirectivesComponent {
  isVisible = false;
  clicks = [];

  changeDisplay() {
    this.clicks.push(this.clicks.length + 1);
    this.isVisible = !this.isVisible;
  }
}
