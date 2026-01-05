import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Interfaces/interfaces';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  users:string[] = ["Vishal", "Rahul", "Prime"]
  private apiUrl:string = 'https://jsonplaceholder.typicode.com/users';

  constructor(private http:HttpClient) {}
  getUsers(){
    return this.users;
  }
  getUsers2(){
    return this.http.get<User[]>(this.apiUrl);
  }
  getUserById(id:number){
    return this.http.get<User>(`${this.apiUrl}/${id}`);
  }
}
