import { Component, OnInit } from '@angular/core';
import {EntityService} from '../../shared/services/entity.service';
import {Circle} from '../../shared/interface';

@Component({
  selector: 'app-pagecircle',
  templateUrl: './pagecircle.component.html',
  styleUrls: ['./pagecircle.component.scss']
})
export class PagecircleComponent implements OnInit {
  circleList: Circle[] = [];

  constructor(private entityService: EntityService) { }

  ngOnInit() {
    this.entityService.getCircleList().subscribe(circles => this.circleList = circles as []);
  }

}
