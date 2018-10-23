import { Component } from '@angular/core';
import { Guid } from "guid-typescript";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  public Id; Guid;

  constructor() {
    this.Id = Guid.create();
  }

}
