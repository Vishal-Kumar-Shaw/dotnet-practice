import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth-service';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {
  constructor(private authservice:AuthService, private router: Router){
    console.log("Login comp")
  }
  get isLoggedIn() {
    return this.authservice.IsLoggedIn();
  }

  authenticate(){
    console.log("Login clicked");
    if(this.isLoggedIn){
      this.authservice.logout();
      this.router.navigate(['/login']);
    }
    else {
      this.authservice.login();
      this.router.navigate(['/home']);
    }
  }
} 
