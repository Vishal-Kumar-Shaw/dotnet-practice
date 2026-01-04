import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  users:string[] = ["Vishal", "Rahul", "Prime"]
  getUsers(){
    return this.users;
  }
}
