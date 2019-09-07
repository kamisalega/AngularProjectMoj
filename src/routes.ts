import {
    EventListComponent,
    CreateEventComponent,
    EventsListResolverService,
    EventRouteActivatorService,
    EventDetailsComponent

} from "./app/events/index";

import {Routes} from "@angular/router";
import {Error404Component} from "./app/errors/error404/error404.component";


export const appRoutes: Routes = [
    {path: 'events/new', component: CreateEventComponent, canDeactivate: ['canDeactivateCreateEvent']},
    {path: 'events', component: EventListComponent, resolve: {events: EventsListResolverService}},
    {path: 'events/:id', component: EventDetailsComponent, canActivate: [EventRouteActivatorService]},
    {path: '404', component: Error404Component},
    {path: 'user', loadChildren: './user/user.module#UserModule'},
    {path: '', redirectTo: '/events', pathMatch: 'full'},


] 