import { Component } from '@angular/core';
import { DriverService } from './services/driver.service';
import { driver } from './models/Driver';
import { OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Drivers.app';

  drivers: driver[] = [];

  constructor(private driverService: DriverService) { }

  ngOnInit(): void {
    this.driverService.getDrivers().subscribe((result: driver[]) => this.drivers = result);
  }
}
