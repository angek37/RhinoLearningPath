import {Component} from '@angular/core';
import {DataStorageService} from '../shared/data-storage.service';
import {faBook} from '@fortawesome/free-solid-svg-icons';
import {AuthService} from '../auth/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent {
  bookIcon = faBook;
  constructor(private dataStorage: DataStorageService, private authService: AuthService) {}

  onSaveData() {
    this.dataStorage.storeRecipes()
      .subscribe(
        (response: Response) => {
          console.log(response);
        }
      );
  }

  onFetchData() {
    this.dataStorage.fetchRecipes();
  }

  logout() {
    this.authService.logout();
  }
}
