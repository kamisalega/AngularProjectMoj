import {Component} from '@angular/core'
import {AuthService} from "../user/auth.service";
import {EventService, ISession} from "../events/shared";

@Component({
    selector: 'nav-bar',
    templateUrl: './nav-bar.component.html',
    styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent {

    searchTerm: string = "";
    foundSessions: ISession[];

    constructor(private authService: AuthService, private eventService: EventService) {

    }

    searchSessions(searchTerm) {
        this.eventService.searchSessions(searchTerm).subscribe(sessions => {
            this.foundSessions = sessions;
            console.log(this.foundSessions);
        });
    }

}