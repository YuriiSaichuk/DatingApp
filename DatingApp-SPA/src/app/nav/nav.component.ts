import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})

export class NavComponent implements OnInit {
  model: any = {};
  userUniqueName: string;

  constructor(public authServise: AuthService, private alertify: AlertifyService) { }

  ngOnInit() {

  }

  login() {
      this.authServise.login(this.model).subscribe(next => {
      this.alertify.success('Logged is successfuly');
    }, error => {
      this.alertify.error(error);
    });
  }

  loggedIn() {
    return this.authServise.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    this.alertify.message('Logged out');
  }
}
