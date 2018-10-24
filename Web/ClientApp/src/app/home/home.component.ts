import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { NgForm } from '@angular/forms';
import { Guid } from "guid-typescript";

//TODO: JS: place as global setting
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  // m e m b e r s
  private http; baseUrl;

  // p r o p e r t i e s 
  public UserId; Guid; products;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.UserId = Guid.create();
    this.baseUrl = baseUrl;
    this.http = http;

    this.getProducts();

    // TODO: JS: LOGIC: must get existing user investments once user auth/registration set up etc..
  }

  // p u b l i c

  public invest(f: NgForm, product: IProduct) {


    let amount = f.value.amount;

    if (this.isValid(product, amount))
    {
      this.addInvestment({ productId: product.id, userId: this.UserId.value, amount: amount })
        .subscribe(result => {
          // HACK: refresh the product entity in a better way
          product.investmentAmount = result.investmentAmount;
          product.investmentComplete = result.investmentComplete;
          product.invested = amount;
        }, error => console.error(error));
    }
  }

  // p r i v a t e

  addInvestment(model: IInvestment) {
    return this.http.post(this.baseUrl + 'api/ledger', model, httpOptions);
  }

  getProducts() {
    this.http.get(this.baseUrl + 'api/products').subscribe(result => {
      this.products = result as IProduct[];

    }, error => console.error(error));
  }

  isValid(product: IProduct, amount: number): boolean {

    // HACK: VALIDATION: purely for POC, add better validation

    let investmentOutstanding = product.investmentRequired - product.investmentAmount;

    if (amount > investmentOutstanding) {
      // HACK: add better UI alerting
      alert("The amount you want to invest exceeds the outstanding investment amount required of €" + investmentOutstanding);
      return false;
    }

    if (amount < 100 || amount > 10000) {
      // HACK: add better UI alerting
      alert("Investment amount must be between 100 and 10000");
      return false;
    }


    return true;
  }

}

// i n t e r f a c e s

interface IProduct {
  id: number,
  name: string,
  description: string,
  investmentRequired: number,
  investmentAmount: number,
  investmentComplete: boolean,
  // HACK: JS: LOGIC: purely for mock, replace with better logic > what investments has a user made?
  invested: number
}

interface IInvestment {
  productId: number,
  userId: Guid,
  amount: number
}
