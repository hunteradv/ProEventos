import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { filter } from 'rxjs';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events: any = []
  public filteredEvents: any = []
  imgWidth: number = 150
  imgMargin: number = 2
  showImage: boolean = true
  private _listFilter: string = ''

  public get listFilter(): string {
    return this._listFilter
  }

  public set listFilter(value: string) {
    this._listFilter = value
    this.filteredEvents = this.listFilter ? this.filterEvents(this.listFilter) : this.events
  }

  filterEvents(filterBy: string): any {
    filterBy = filterBy.toLocaleLowerCase()
    return this.events.filter(
      (event: any) => event.title.toLocaleLowerCase().indexOf(filterBy) !== -1 ||
                      event.local.toLocaleLowerCase().indexOf(filterBy) !== -1
    )
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEvents()
  }

  alterImage() {
    this.showImage = !this.showImage
  }

  public getEvents(): void {
    this.http.get('https://localhost:5001/api/events').subscribe(
      response => {
        this.events = response
        this.filteredEvents = this.events
      },
      error => console.log(error)
    )
  }

}
