import { Injectable } from '@angular/core';
import{ department} from './department';


@Injectable({
  providedIn: 'root'
})
export class DepService {
deplist:department[]=[
  {depno:1,name:'Engineering',groupname:'Research and developement',modifieddate:new Date()},
  {depno:2,name:'Tool design',groupname:'Inventory Marketing',modifieddate:new Date()},
  {depno:3,name:'Sales',groupname:'Sales and Marketing',modifieddate:new Date()},
  {depno:4,name:'Marketing',groupname:'Manufacturing',modifieddate:new Date()},
]
  constructor() { }
  dispdata()
  {
    return this.deplist;
  }
  
  
}
