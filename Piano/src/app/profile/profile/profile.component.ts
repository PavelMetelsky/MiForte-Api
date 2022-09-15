import { Component, OnInit } from '@angular/core';
import { NavigateService } from 'src/app/shared/base/navigate.service';
import { StorageService } from 'src/app/storage.service';

interface IUserDetails {
  crmLink: string;
  id: string;
  email: string;
  firstName: string;
  lastName: string;
  phoneNumber: string;
  requestedCompanyName: string;
  totalSearches: number;
  totalSearchesEver: number;
  status: number;
  isAdmin: boolean;
  isPrimary: boolean;
  mailingList: boolean;
}

@Component({
  selector: 'p-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss'],
})
export class ProfileComponent {
  public userModel: IUserDetails;
  public accessLevelDisplay: string;

  public serverValidationFailed: boolean;
  public serverErrors: any;
  public submitted = false;
  public passwordLastUpdate: string;
  public isActiveUser = false;

  public a: any;

  constructor(
    private storageService: StorageService,
    private navigate: NavigateService
  ) {
    this.a = this.storageService.getItem('userModel');
    console.log(this.a.email);
  }

  public onMainPage(): void {
    this.navigate.toHomePage();
  }
}
