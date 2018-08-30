import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms';
import {AuthService} from '../auth.service';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit {
  signinStatus = false;
  error = false;

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  onSignin(form: NgForm) {
    this.error = false;
    const email = form.value.email;
    const password = form.value.password;
    this.authService.signinUser(email, password);
      // .then(
      //   (request) => {
      //     console.log(request);
      //     this.signinStatus = true;
      //     form.reset();
      //     setInterval(
      //       () => this.signinStatus = false,
      //       5000
      //     );
      //   }
      // )
      // .catch(
      //   () => this.error = true
      // );
  }

}
