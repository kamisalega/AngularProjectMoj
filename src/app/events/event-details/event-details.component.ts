import {Component, OnInit} from '@angular/core';
import {EventService} from "../shared/event.service";
import {ActivatedRoute} from "@angular/router";
import {IEvent} from "../shared";

@Component({
    selector: 'app-event-details',
    templateUrl: './event-details.component.html',
    styleUrls: ['./event-details.component.css']
})
export class EventDetailsComponent implements OnInit {

    event:IEvent;
    
    constructor(private eventService: EventService, private route: ActivatedRoute) {
    }

    ngOnInit() {
        let idEvent = parseInt( this.route.snapshot.params['id']);
        this.event = this.eventService.getEvent(idEvent);  
    }

}
