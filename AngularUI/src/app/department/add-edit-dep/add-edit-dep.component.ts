import { Component, OnInit,Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-dep',
  templateUrl: './add-edit-dep.component.html',
  styleUrls: ['./add-edit-dep.component.css']
})
export class AddEditDepComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() dep:any;
  DepartmentId:string="";
  DepartmentName:string="";

  ngOnInit(): void {
    this.DepartmentId=this.dep.departmentID;
    this.DepartmentName=this.dep.departmentName;
  }

  addDepartment(){
    var val = {DepartmentId:this.DepartmentId,
                DepartmentName:this.DepartmentName};
    this.service.addDepartment(val).subscribe(res=>{
      alert("Added Successfully.");
    });
  }

  updateDepartment(){
    var val = {departmentID:this.DepartmentId,
      departmentName:this.DepartmentName};
    this.service.updateDepartment(val).subscribe(res=>{
    alert("Updated Successfully.");
    });
  }

}
