import { Component, OnInit } from '@angular/core';
import {EventService, IEvent} from "../shared";
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-event-about',
  templateUrl: './event-about.component.html',
  styleUrls: ['./event-about.component.css']
})
export class EventAboutComponent implements OnInit {

  events: IEvent[];

  constructor(private eventService: EventService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.events = this.route.snapshot.data['events']
  }

}
