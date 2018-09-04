import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Params, Router} from '@angular/router';
import {CrmService} from '../crm/crm.service';

@Component({
  selector: 'app-token',
  templateUrl: './token.component.html',
  styleUrls: ['./token.component.css']
})
export class TokenComponent implements OnInit {
  token = '';

  constructor(private route: ActivatedRoute, private router: Router, private crmSvc: CrmService) {
  }

  ngOnInit() {
    this.route.params
      .subscribe(
        (params: Params) => {
          console.log(params);
          this.token = params['id'];
        }
      );
    this.router.navigate(['/']);
  }

}
