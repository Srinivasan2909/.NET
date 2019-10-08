import { Component, OnInit } from '@angular/core';
import{ department} from '../department';
import{ DepService} from '../dep.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  dep1= new department();
  constructor(private dd:DepService,private route:Router) { }
  dispdata()
  {
    this.dd.deplist.push(this.dep1);
    this.route.navigate(['list']);
  }

  

  ngOnInit() {
  }

}
