import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="https://localhost:44301/api";
readonly PhotoUrl = "http://localhost:44301/Photos/";


  constructor(private http:HttpClient) { }

  depid:number=0;
  empid:number=0;

  getDepList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/department');
  }

  addDepartment(val:any){
    return this.http.post(this.APIUrl+'/Department',val);
  }

  updateDepartment(val:any){
    this.depid=val.departmentID
    return this.http.put(this.APIUrl+'/Department/update-department-by-id/'+this.depid,val);
  }

  deleteDepartment(val:any){
    return this.http.delete(this.APIUrl+'/Department/delete-department-by-id/'+val);
  }


  getEmpList():Observable<any[]>{
    console.log(this.APIUrl);
    return this.http.get<any>(this.APIUrl+'/Employee');
  }

  addEmployee(val:any){
    return this.http.post(this.APIUrl+'/Employee',val);
  }

  updateEmployee(val:any){
    this.empid = val.employeeID;
    return this.http.put(this.APIUrl+'/Employee/update-employee-by-id/'+this.empid, val);
  }

  deleteEmployee(val:any){
    return this.http.delete(this.APIUrl+'/Employee/delete-employee-by-id/'+val);
  }


  UploadPhoto(val:any){
    return this.http.post(this.APIUrl+'/Employee/SaveFile',val);
  }

  getAllDepartmentNames():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/department');
  }

}
