import { Injectable } from '@angular/core';
import  * as alertify from 'alertifyjs';
@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() { }

  confirm(message: string, okCallback: () => any) {
    alertify.confirm(message, (e: any) => {
      if (e) {
        okCallback();
      } else  {}
    });
  }
  success(massge: string) {
    alertify.success(massge);
  }

  error(massge: string) {
    alertify.error(massge);
  }

  warning(massge: string) {
    alertify.warnin(massge);
  }

  message(massge: string) {
    alertify.message(massge);
  }
}


