import { Component } from '@angular/core';
import { UserService } from '../services/userService';
import { CommonModule } from '@angular/common';
import { User } from '../Interfaces/interfaces';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-users',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './users.component.html',
  styleUrl: './users.component.css',
})
export class UsersComponent {
  users:any[]=[];
  users2:User[]=[];

  constructor(private userService: UserService){}
  ngOnInit(){
    this.userService.getUsers2().subscribe({
      next: (data) => {
        this.users2 = data
        console.log(this.users2);
      },
      error: (err) => console.error(err)
    });
  }

}
