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
  users:any[]=[];
  users2:any[]=[];

  constructor(private userService: UserService){}
  ngOnInit(){
    this.userService.getUsers2().subscribe({
      next: (data) => this.users2 = data,
      error: (err) => console.error(err)
    });
  }
}
