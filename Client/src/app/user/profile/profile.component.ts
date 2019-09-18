import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {AuthService} from "../auth.service";
import {Router} from "@angular/router";

@Component({
    selector: 'app-profile',
    templateUrl: './profile.component.html',
    styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

    profileForm: FormGroup
    private firstName: FormControl
    private lastName: FormControl

    constructor(private authService: AuthService, private router: Router) {
    }

    ngOnInit() {

        this.firstName = new FormControl(this.authService.currentUser.firstName,
            [Validators.required, Validators.pattern('[a-zA-Z].*')])
        this.lastName = new FormControl(this.authService.currentUser.lastName, Validators.required)
        this.profileForm = new FormGroup({
            firstName: this.firstName,
            lastName: this.lastName
        })

    }

    cancel() {

        this.router.navigate(['events'])

    }

    saveProfile(formValues) {

        if (this.profileForm.valid) {
            this.authService.updateCurrentUser(formValues.firstName, formValues.lastName)
        }

    }

    validateFirstName() {

        return this.firstName.valid || this.firstName.touched

    }

    validateLastName() {

        return this.lastName.valid || this.lastName.touched

    }

}
