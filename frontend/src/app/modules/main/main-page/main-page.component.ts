import { Component, OnInit } from '@angular/core';
import { User } from "../../../core/models/user/user";
import { AuthService } from "../../../core/services/auth.service";
import { Router } from "@angular/router";
import { Subject, takeUntil } from "rxjs";
import { EventService } from "../../../core/services/event.service";

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.sass']
})
export class MainPageComponent implements OnInit {
    public authorizedUser: User;

    private unsubscribe$ = new Subject<void>();

    constructor(
        private authService: AuthService,
        private router: Router,
        private eventService: EventService
    ) { }

    ngOnInit(): void {
        this.getUser();
        this.eventService.userChangedEvent$
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => this.getUser());
    }

    public logout() {
        this.authService.logout();
        this.authorizedUser = undefined!;
        this.router.navigate(['/']);
    }

    private getUser() {
        if (!this.authService.areTokensExist()) {
            return;
        }

        this.authService
            .getUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) =>
            {
                this.authorizedUser = user;
            });
    }
}
