import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UsersComponent } from './users/users.component';
import { UserDetailComponent } from './user-detail/user-detail.component';
import { authGuard } from './authGuard/auth.guard';

export const routes: Routes = [
   { path: '', component: HomeComponent},
   { path: 'users', component: UsersComponent},
   { path: 'home', component: HomeComponent},
   { path: 'users/:id', component: UserDetailComponent, canActivate:[authGuard]}
];
