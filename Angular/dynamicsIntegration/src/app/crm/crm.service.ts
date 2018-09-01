import {Injectable} from '@angular/core';
import {Contact} from '../bussinessType/contact.model';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {environment} from '../../environments/environment';
import {MsAdalAngular6Service} from 'microsoft-adal-angular6';

@Injectable()
export class CrmService {
  contacts: Contact;

  constructor(private http: HttpClient, private adalService: MsAdalAngular6Service) { }

  getContacts() {
    // const token = new HttpHeaders({'Authorization': this.getToken()});
    // this.http.get(environment.ad.endpoints.crm + 'contacts')
    //   .subscribe(
    //     (response) => console.log(response),
    //     (error) => {
    //       console.log('An error has been occurred, details: ' + error.message);
    //       console.log(error);
    //     }
    //   );
  }

  getToken() {

  }
}
