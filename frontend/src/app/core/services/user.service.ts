import { Injectable } from '@angular/core';
import { User } from "../models/user/user";
import { HttpInternalService } from "./http-internal.service";

@Injectable({
  providedIn: 'root'
})
export class UserService {
    public routePrefix = '/api/users';

    constructor(private httpService: HttpInternalService) {}

    public getUserFromToken() {
        return this.httpService.getRequest<User>(`${this.routePrefix}/fromToken`);
    }
}
