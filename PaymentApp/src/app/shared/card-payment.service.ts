import { CardPayment } from './card-payment.model';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class CardPaymentService {

  constructor(private http:HttpClient) { }

  formData:CardPayment = new CardPayment();
  cardList:CardPayment[];

  readonly baseUrl = 'https://localhost:44336/api/PaymentDetail';

  postCardDetail(){
    return this.http.post(this.baseUrl, this.formData);
  }

  putCardDetail(){
    return this.http.put(this.baseUrl+'/'+this.formData.id, this.formData);
  }

  getCardList(){
    return this.http.get(this.baseUrl)
    .toPromise()
    .then(res => this.cardList = res as CardPayment[]);
  }

  deleteCardDetail(id:number){
    return this.http.delete(this.baseUrl+'/'+id);
  }

}
