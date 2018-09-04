import { Component, OnInit } from '@angular/core';
import {CrmService} from '../crm/crm.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private crmSvc: CrmService) { }

  ngOnInit() {
  }

  onLogin() {
    this.crmSvc.login();
  }

  onGetContacts() {
    this.crmSvc.getContacts();
  }

}
