import { Component, OnInit } from '@angular/core';
import { department} from '../department'
import { DepService} from '../dep.service'

@Component({
  selector: 'app-depinfo',
  templateUrl: './depinfo.component.html',
  styleUrls: ['./depinfo.component.css']
})
export class DepinfoComponent implements OnInit {
  ll:department;
  deplist:department[];


  constructor(private dd:DepService) {
    this.deplist=this.dd.dispdata();
   }

  ngOnInit() {
  }
  deletes(i :number)
  {
    this.dd.deplist.splice(i,1);
  }
ed=false;
edits(i : number)
{
  this.ed=true;
  this.ll=this.dd.deplist[i];
}
up()
{
  this.ed=false;
}
}
