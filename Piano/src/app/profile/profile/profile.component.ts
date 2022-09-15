import { Component, OnInit } from '@angular/core';

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
export class ProfileComponent implements OnInit {
  public userModel: IUserDetails;
  public accessLevelDisplay: string;

  public serverValidationFailed: boolean;
  public serverErrors: any;
  public submitted = false;
  public passwordLastUpdate: string;
  public isActiveUser = false;
  constructor() {}

  ngOnInit(): void {}
}
