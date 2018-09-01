import {Component, OnInit} from '@angular/core';
import {CrmService} from './crm/crm.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private crmService: CrmService) { }

  ngOnInit(): void {
    this.crmService.getContacts();
  }

}
