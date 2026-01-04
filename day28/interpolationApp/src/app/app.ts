import { CommonModule } from '@angular/common';
import { Component, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { UserService } from './services/userService';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, FormsModule, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  constructor(private userservice: UserService){ }

  protected readonly title = signal('interpolationApp');
  name = 'Vishal Kumar Shaw';
  isDisabled = true;
  value = 0;
  inputVal = "Test"
  IsLoggedIn:boolean = false;
  users:string[]=[];
  counterVal:number = 5;
  userName:string='';

  ngOnInit(){
    this.users = this.userservice.getUsers();
  }

  increament() {
    this.value++;
  }
  decreament() {
    if(this.value > 0) {
      this.value--;
    }
  }
  login(){
    this.IsLoggedIn = true;
  }
  logout(){
    this.IsLoggedIn = false;
  }
  addUser(){
    this.userservice.addUser(this.userName);
    this.userName='';
  }
}
