import { Injectable } from '@angular/core';
import { Employeedetail } from './employeedetail.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeedetailService {
  formData: Employeedetail;
  constructor() { }
}
