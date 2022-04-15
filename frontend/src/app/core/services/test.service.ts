import { Injectable } from '@angular/core';
import { HttpInternalService } from "./http-internal.service";
import { Test } from "../models/test/test";

@Injectable({
  providedIn: 'root'
})
export class TestService {
    public routePrefix = '/api/tests';

    constructor(private httpService: HttpInternalService) {}

    public getShuffledTests(takeQuantity: number) {
        return this.httpService.getRequest<Test[]>(`${this.routePrefix}/allShuffled`, {takeQuantity});
    }

    public getById(id: number) {
        return this.httpService.getRequest<Test>(`${this.routePrefix}/${id}`);
    }
}
