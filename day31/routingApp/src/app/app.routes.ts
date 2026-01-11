import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UsersComponent } from './users/users.component';
import { UserDetailComponent } from './user-detail/user-detail.component';
import { authGuard } from './authGuard/auth.guard';
import { LoginComponent } from './login/login.component';

export const routes: Routes = [
   { path: '', redirectTo:'/login', pathMatch:'full'},
   { path: 'login', component: LoginComponent},
   { path: 'users', component: UsersComponent, canActivate: [authGuard]},
   { path: 'users/:id', component: UserDetailComponent, canActivate:[authGuard]},
   { path: 'home', component: HomeComponent, canActivate: [authGuard]},
   { path: '**', redirectTo: 'login' }
   
];
