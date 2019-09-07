import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';

import {
    EventListComponent,
    EventThumbnailComponent,
    EventService,
    CreateEventComponent,
    EventsListResolverService,
    EventRouteActivatorService,
    EventDetailsComponent, 
    EventAboutComponent,
    EventMainSectionComponent

} from './events';
import {NavBarComponent} from './nav/nav-bar.component';
import {appRoutes} from "../routes";
import {RouterModule} from "@angular/router";
import {EventsAppComponent} from "./events/events-app/events-app.component";
import {ToastrService} from "./common/toastr.service";
import {Error404Component} from './errors/error404/error404.component';
import {AuthService} from "./user/auth.service";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";


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
        EventListComponent


    ],
    imports: [
        BrowserModule, FormsModule, RouterModule.forRoot(appRoutes), ReactiveFormsModule
    ],
    providers: [
        EventService,
        ToastrService,
        EventRouteActivatorService,
        EventsListResolverService,
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
