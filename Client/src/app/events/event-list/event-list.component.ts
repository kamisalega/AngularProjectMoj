import {Component, OnInit} from '@angular/core';
import {EventService, IEvent} from "../shared";
import {ActivatedRoute} from "@angular/router";


@Component({
    selector: 'app-event-list',
    templateUrl: './event-list.component.html',
    styleUrls: ['./event-list.component.css']
})
export class EventListComponent implements OnInit {
    
    events: IEvent[];

    constructor(private eventService: EventService, private route: ActivatedRoute) {

    }

    ngOnInit() {
        this.events = this.route.snapshot.data['events'];
    }


}
