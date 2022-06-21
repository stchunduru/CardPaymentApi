import { ToastrService } from 'ngx-toastr';
import { CardPaymentService } from './../shared/card-payment.service';
import { Component, OnInit } from '@angular/core';
import { CardPayment } from '../shared/card-payment.model';


@Component({
  selector: 'app-card-payment',
  templateUrl: './card-payment.component.html',
  styleUrls: ['./card-payment.component.css']
})
export class CardPaymentComponent implements OnInit {

  constructor(public service:CardPaymentService, private toastr:ToastrService) {}

  testList:CardPayment[];

  ngOnInit(): void {
    this.service.getCardList();
  }

  populateForm(form:CardPayment){
    this.service.formData = Object.assign({}, form);
  }

  onDelete(id:number){
    this.service.deleteCardDetail(id)
    .subscribe(
      res=>{
        this.service.getCardList();
        this.toastr.error("Deleted successfully", "Card Details");

      },
      err=>{
        this.toastr.error("Delete unsuccessful", "Card Details");
        console.log(err);
      }
    );
  }

}
