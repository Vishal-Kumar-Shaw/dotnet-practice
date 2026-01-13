import { Component, signal } from '@angular/core';
import { Router, RouterLink, RouterOutlet } from '@angular/router';
import { AuthService } from './services/auth-service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('routingApp');
   constructor(
    private authservice: AuthService,
    private router: Router
  ) {}

  get isLoggedIn() {
    return this.authservice.IsLoggedIn();
  }

  authenticate() {
    if (this.isLoggedIn) {
      this.authservice.logout();
      this.router.navigate(['/login']);
    } else {
      this.authservice.login();
      this.router.navigate(['/home']);
    }
  }
}
