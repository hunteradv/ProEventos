import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events: any = []

  imgWidth: number = 150
  imgMargin: number = 2
  showImage: boolean = true

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEvents()
  }

  alterImage() {
    this.showImage = !this.showImage
  }

  public getEvents(): void {
    this.http.get('https://localhost:5001/api/events').subscribe(
      response => this.events = response,
      error => console.log(error)
    )
  }

}
