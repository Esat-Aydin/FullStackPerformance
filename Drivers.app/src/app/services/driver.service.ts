import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { driver } from '../models/Driver';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DriverService {

  constructor(private http: HttpClient) { }

  driverUrl: string = environment.apiUrl + '/Driver';

  public getDrivers = (): Observable<driver[]> => this.http.get<driver[]>(this.driverUrl);
}
