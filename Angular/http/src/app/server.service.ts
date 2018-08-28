import {Injectable} from '@angular/core';
import {Http, Headers} from '@angular/http';
import {map, catchError} from 'rxjs/operators';
import {throwError} from 'rxjs';

@Injectable()
export class ServerService {
  constructor(private http: Http) {}
  storeServers(servers: any) {
    const headers = new Headers({'Content-Type': 'application/json'});
    // return this.http.post('https://angularcourse-5a78f.firebaseio.com/data.json',
    //   servers,
    //   {headers: headers});
    return this.http.put('https://angularcourse-5a78f.firebaseio.com/data.json',
      servers,
      {headers: headers});
  }

  getServers() {
    return this.http.get('https://angularcourse-5a78f.firebaseio.com/data.json')
      .pipe(map(
        (response: Response) => {
          const data = response.json();
          for (const server of data) {
            server.name = 'FETCHED_' +  server.name;
          }
          return data;
        }
      )).pipe(catchError(error => {
        return throwError(error);
      }));
  }

  getAppName() {
    return this.http.get('https://angularcourse-5a78f.firebaseio.com/AppName.json')
      .pipe(map(
        (response: Response) => {
          return response.json();
        }
      ));
  }
}
