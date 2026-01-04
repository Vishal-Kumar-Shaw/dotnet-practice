import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

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
    return this.http.get<any[]>(this.apiUrl);
  }
}
