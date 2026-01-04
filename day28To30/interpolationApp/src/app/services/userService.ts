import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  users:string[] = ['Vishal', 'Rahul', 'Amit'];
  getUsers(){
    return this.users;
  }
  addUser(user:string){
    this.users.push(user);
  }

}
