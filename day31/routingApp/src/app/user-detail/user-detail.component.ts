// import { Component } from '@angular/core';
// import { UserService } from '../services/userService';
// import { ActivatedRoute } from '@angular/router';
// import { User } from '../Interfaces/interfaces';
// import { CommonModule } from '@angular/common';

// @Component({
//   selector: 'app-user-detail',
//   standalone: true,
//   imports: [CommonModule],
//   templateUrl: './user-detail.component.html',
//   styleUrls: ['./user-detail.component.css'],
// })
// export class UserDetailComponent {
//   id!:string|null;
//   constructor(private userservice:UserService, private route:ActivatedRoute){ }
//   user: User | null = null;
//   userLoad:boolean = true;
//   ngOnInit(){
//     // console.log("ngoninit called")
//     // const id = this.route.snapshot.paramMap.get('id');
//     // console.log(id);
//     // this.userservice.getUserById(Number(id)).subscribe({
//     //    next: (data) => {
//     //     this.user = data
//     //     console.log(this.user);
//     //   },
//     //   error: (err) => console.error(err)
//     // })
//     this.route.paramMap.subscribe(params =>{
//       const id = params.get('id');
//       console.log(id);
//       if(id){
//         this.userservice.getUserById(+id).subscribe({
//           next: (data) => {
//             console.log(data);
//             this.user = data
//             this.userLoad = false
//           },
//           error: (err) => console.error(err),
//         })
//       }
//     })
//   }
// }
import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActivatedRoute } from '@angular/router';
import { UserService } from '../services/userService';
import { User } from '../Interfaces/interfaces';
import { filter, map, Observable, switchMap } from 'rxjs';

@Component({
  selector: 'app-user-detail',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.css'], // ✅ FIX
})
export class UserDetailComponent{

  user: User | null = null;   // ✅ FIX
  userLoad = true;
  user$!: Observable<User>;

  constructor(
    private userservice: UserService,
    private route: ActivatedRoute
  ) {
     this.user$ = this.route.paramMap.pipe(
      map(params => params.get('id')),
      filter((id): id is string => !!id),
      switchMap(id => this.userservice.getUserById(+id))
    );
  }

  // ngOnInit() {
  //   this.route.paramMap.subscribe(params => {
  //     const id = params.get('id');
  //     if (id) {
  //       this.userservice.getUserById(+id).subscribe({
  //         next: data => {
  //           console.log('USER DATA', data);
  //           this.user = data;
  //           this.userLoad = false;
  //         },
  //         error: err => console.error(err),
  //       });
  //     }
  //   });
  // }
}
