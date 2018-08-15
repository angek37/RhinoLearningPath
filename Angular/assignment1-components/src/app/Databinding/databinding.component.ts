import { Component } from '@angular/core';

@Component({
  selector: 'app-databinding',
  templateUrl: './databinding.component.html'
})
export class DatabindingComponent {
  username = '';

  isEmpty() {
    return !(this.username.length > 0);
  }

  getUsername() {
    return this.username;
  }

  reset() {
    this.username = '';
  }

}
