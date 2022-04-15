import { Injectable } from '@angular/core';
import { environment } from "../../../environments/environment";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class HttpInternalService {
    public baseUrl: string = environment.apiUrl;
    public headers = new HttpHeaders();

    constructor(private http: HttpClient) {}

    public getHeaders(): HttpHeaders {
        return this.headers;
    }

    public getRequest<T>(url: string, httpParams?: any): Observable<T> {
        return this.http.get<T>(this.buildUrl(url), { headers: this.getHeaders(), params: httpParams });
    }

    public postRequest<T>(url: string, payload: object): Observable<T> {
        return this.http.post<T>(this.buildUrl(url), payload, { headers: this.getHeaders() });
    }

    public putRequest<T>(url: string, payload: object): Observable<T> {
        return this.http.put<T>(this.buildUrl(url), payload, { headers: this.getHeaders() });
    }

    public deleteRequest<T>(url: string, httpParams?: any): Observable<T> {
        return this.http.delete<T>(this.buildUrl(url), { headers: this.getHeaders(), params: httpParams });
    }

    public buildUrl(url: string): string {
        if (url.startsWith('http://') || url.startsWith('https://')) {
            return url;
        }
        return this.baseUrl + url;
    }
}
