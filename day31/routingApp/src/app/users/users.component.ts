import { Component } from '@angular/core';
import { UserService } from '../services/userService';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-users',
  imports: [CommonModule],
  templateUrl: './users.component.html',
  styleUrl: './users.component.css',
})
export class UsersComponent {
  users:string[]=[];

  constructor(private userService: UserService){}
  ngOnInit(){
    this.users = this.userService.getUsers();
  }
}
