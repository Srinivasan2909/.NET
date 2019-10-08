import { Component } from '@angular/core';
import { department} from './department';
import { DepService} from './dep.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'department';
}
