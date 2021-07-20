import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ValueService {

  constructor(private http: HttpClient) { }

  getValuesList() {
   return  this.http.get(environment.apiBaseURI + '/Value');

  }
}
