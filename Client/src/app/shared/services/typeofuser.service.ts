import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../environments/environment';


@Injectable({
  providedIn: 'root'
})
export class TypeofuserService {

  constructor(private http: HttpClient) { }

  getTypeOfUserList() {
    return  this.http.get(environment.apiBaseURI + '/TypeOfUsers');

  }
}
