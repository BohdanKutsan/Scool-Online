import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent implements OnInit {
  componentnumber = 1;

  constructor() { }

  ngOnInit() {
  }

  componentListUsers() {
    this.componentnumber = 1;
  }

  AdvertisementsListComponent() {
    this.componentnumber = 2;
  }

  RegisterComponent() {
    this.componentnumber = 3;
  }

  CircleComponent() {
    this.componentnumber = 4;
  }

  ScheduleOfLessonComponent() {
    this.componentnumber = 5;
  }
}
