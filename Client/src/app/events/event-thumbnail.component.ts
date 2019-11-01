import { Component, Input, Output, EventEmitter } from "@angular/core";
import {IEvent} from "./shared";


@Component({
    selector: 'event-thumbnail',
    template: `
        <div [routerLink]="['/events', event.id]" class="well hoverwell thumbnail">
            <h2>{{event?.name | uppercase}}</h2>
            <div>Data: {{event?.date | date: 'dd/MM/yyyy'}}</div>
            <div style="..." [ngStyle]="getStartTimeStyle()" [ngSwitch]="event?.time">
                Czas: {{event?.time}}
                <span *ngSwitchCase="'8:00 am'">(Wczesny start)</span>
                <span *ngSwitchCase="'10:00 am'">(Późny start)</span>
                <span *ngSwitchDefault>(Normalny start)</span>
            </div>
            <div>Cena: {{ event?.price | currency: 'PLN '}} </div>
            <div *ngIf="event?.location">
                <span>Lokacja: {{event?.location?.address}}</span>
                <span class="pad-left">{{event?.location?.city}}, {{event?.location?.country}}</span>
            </div>
            <div *ngIf="event?.onlineUrl">
                Adres strony internetowej: {{event?.onlineUrl}}
            </div>
        </div>
    `,
    styles: [`
    .thumbnail {min-height: 210px;}
    .pad-left { margin-left: 100px; }
    .well div{ color: #bbb;}
    `]
})
export class EventThumbnailComponent
{
    @Input() event:IEvent;

    getStartTimeStyle(): any{
        if (this.event && this.event.time === '8:00 am')
        return {color: '#003300', 'font-weight': 'bold'}
        return {}

    }
}