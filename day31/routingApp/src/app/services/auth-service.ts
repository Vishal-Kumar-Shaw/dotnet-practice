import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  LoggedIn: boolean = false;

  IsLoggedIn():boolean{
    return this.LoggedIn;
  }

  login(){
    this.LoggedIn = true;
  }
  
  logout(){
    this.LoggedIn = false;
  }

}
