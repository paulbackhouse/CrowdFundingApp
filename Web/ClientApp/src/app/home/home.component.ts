import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Guid } from "guid-typescript";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  public Id; Guid; http; baseUrl; products;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.Id = Guid.create();
    this.baseUrl = baseUrl;
    this.http = http;

    this.getProducts();
  }

  getProducts()
  {
    this.http.get(this.baseUrl + 'api/products').subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }


}
