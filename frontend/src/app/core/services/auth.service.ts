import { Injectable } from '@angular/core';
import { User } from "../models/user/user";
import { HttpInternalService } from "./http-internal.service";
import { map, Observable, of } from "rxjs";
import { Register } from "../models/auth/register";
import { Login } from "../models/auth/login";
import { AuthUser } from "../models/auth/auth-user";
import { AccessToken } from "../models/auth/access-token";
import { UserService } from "./user.service";
import { EventService } from "./event.service";

@Injectable({
  providedIn: 'root'
})
export class AuthService {
    public routePrefix = '/api/auth';
    private user: User = {} as User;

    constructor(
        private httpService: HttpInternalService,
        private userService: UserService,
        private eventService: EventService
    ) { }

    public getUser() {
        return this.user
            ? of(this.user)
            : this.userService.getUserFromToken().pipe(
                map((resp) => {
                    this.user = resp;
                    this.eventService.userChanged(this.user);
                    return this.user;
                })
            );
    }

    public register(register: Register) {
        return this.httpService.postRequest<User>(`${this.routePrefix}/register`, register);
    }

    public login(login: Login) {
        return this._handleAuthResponse(this.httpService.postRequest<AuthUser>(`${this.routePrefix}/login`, login));
    }

    public logout() {
        localStorage.removeItem('accessToken');
        this.user = undefined!;
        this.eventService.userChanged(undefined!);
    }

    public areTokensExist() {
        return localStorage.getItem('accessToken');
    }

    private _handleAuthResponse(observable: Observable<AuthUser>) {
        return observable.pipe(
            map((resp) => {
                this._setToken(resp.token);
                this.user = resp.user;
                this.eventService.userChanged(this.user);
                return resp.user;
            })
        );
    }

    private _setToken(accessToken: AccessToken) {
        if (accessToken && accessToken.token) {
            localStorage.setItem('accessToken', JSON.stringify(accessToken.token));
        }
    }
}
