import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {HttpClientModule} from "@angular/common/http";

import {
    EventListComponent,
    EventThumbnailComponent,
    EventService,
    CreateEventComponent,
    EventsListResolverService,
    EventDetailsComponent,
    EventAboutComponent,
    EventMainSectionComponent,
    CreateSessionComponent,
    SessionListComponent,
    VoterService,
    DurationPipe,
    UpvoteComponent,
    LocationValidatorDirective, 
    EventResolverService
} from './events/index';
import {
    JQ_TOKEN,
    TOASTR_TOKEN,
    Toastr,
    CollapsibleWellComponent,
    SimpleModalComponent,
    JQueryService
} from './common/index';
import {NavBarComponent} from './nav/nav-bar.component';
import {appRoutes} from "../routes";
import {RouterModule} from "@angular/router";
import {EventsAppComponent} from "./events/events-app/events-app.component";
// import {TOASTR_TOKEN as TOASTR_TOKEN2} from "./common/toastr2.service";
import {Error404Component} from './errors/error404/error404.component';
import {AuthService} from "./user/auth.service";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {ModalTriggerDirective} from "./common/modal-trigger.directive";


let toastr: Toastr = window['toastr'];
let jQuery = window['$'];

@NgModule({
    declarations: [
        EventsAppComponent,
        EventThumbnailComponent,
        NavBarComponent,
        EventDetailsComponent,
        CreateEventComponent,
        Error404Component,
        EventAboutComponent,
        EventMainSectionComponent,
        EventListComponent,
        CreateSessionComponent,
        SessionListComponent,
        CollapsibleWellComponent,
        DurationPipe,
        SimpleModalComponent,
        ModalTriggerDirective,
        UpvoteComponent,
        LocationValidatorDirective
    ],
    imports: [
        BrowserModule,
        FormsModule,
        RouterModule.forRoot(appRoutes),
        ReactiveFormsModule,
        HttpClientModule
    ],
    providers: [
        EventService,
        {
            provide: TOASTR_TOKEN,
            useValue: toastr
        },
        {
            provide: JQ_TOKEN,
            useValue: jQuery
        },
        EventResolverService,
        EventsListResolverService,
        VoterService,
        AuthService,

        {provide: 'canDeactivateCreateEvent', useValue: checkDirtyState}
    ],
    bootstrap: [EventsAppComponent]
})
export class AppModule {
}

export function checkDirtyState(component: CreateEventComponent) {
    if (component.isDirty)
        return window.confirm('You have not saved this event, do you really want to cancel?')

    return true;
}
