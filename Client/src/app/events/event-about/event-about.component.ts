import { Component, OnInit } from '@angular/core';
import {EventService, IEvent} from "../shared";
import {ToastrService} from "../../common/toastr.service";
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-event-about',
  templateUrl: './event-about.component.html',
  styleUrls: ['./event-about.component.css']
})
export class EventAboutComponent implements OnInit {

  events: IEvent[];

  constructor(private eventService: EventService, private toastr: ToastrService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.events = this.route.snapshot.data['events']
  }

  handleThumbnailClick(eventName) {
    this.toastr.success(eventName);
  }
}
