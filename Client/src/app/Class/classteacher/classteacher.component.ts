import { Component, OnInit } from '@angular/core';
import {Teacher} from '../../shared/interface';
import {EntityService} from '../../shared/services/entity.service';

@Component({
  selector: 'app-classteacher',
  templateUrl: './classteacher.component.html',
  styleUrls: ['./classteacher.component.scss']
})
export class ClassteacherComponent implements OnInit {
  teacherList: Teacher[] = [];

  constructor(private entityService: EntityService) { }

  ngOnInit() {
    this.entityService.getTeacherList().subscribe(teachers => this.teacherList = teachers as []);
  }

}
