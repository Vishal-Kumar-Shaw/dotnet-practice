import { Component, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('interpolationApp');
  name = 'Vishal Kumar Shaw';
  isDisabled = false;
  value = 0;
  inputVal = "Test"
  increament() {
    this.value++;
  }
  decreament() {
    if(this.value > 0) {
      this.value--;
    }
  }
}
