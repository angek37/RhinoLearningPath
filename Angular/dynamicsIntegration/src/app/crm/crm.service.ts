import {Injectable} from '@angular/core';
import {Contact} from '../bussinessType/contact.model';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {environment} from '../../environments/environment';
import {MsAdalAngular6Service} from 'microsoft-adal-angular6';

@Injectable()
export class CrmService {
  contacts: Contact;
  private token;

  constructor(private http: HttpClient, private adalService: MsAdalAngular6Service) { }

  getContacts() {
    this.getToken();
    this.http.get(environment.ad.crm + 'contacts', {
      headers: new HttpHeaders()
        .set('Authorization', 'Bearer ' + this.token)
        .set('Accept', 'application/json')
        .set('Content-Type', 'application/json; charset=utf-8')
        .set('OData-MaxVersion', '4.0')
        .set('OData-Version', '4.0')
    })
      .subscribe(
        (response) => console.log(response),
        (error) => {
          console.log('An error has been occurred, details: ' + error.message);
          console.log(error);
        }
      );
  }

  getToken() {
    this.adalService.acquireToken(environment.ad.resource)
      .subscribe(
        (resToken: string) => {
          this.token = resToken;
        }
      );
  }

  login() {
    this.adalService.login();
  }

  isAuthenticated() {
    return this.isAuthenticated;
  }
}
