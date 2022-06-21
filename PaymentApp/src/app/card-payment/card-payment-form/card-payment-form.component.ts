import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CardPaymentService } from 'src/app/shared/card-payment.service';
import { CardPayment } from 'src/app/shared/card-payment.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-card-payment-form',
  templateUrl: './card-payment-form.component.html',
  styleUrls: ['./card-payment-form.component.css']
})
export class CardPaymentFormComponent implements OnInit {

  constructor(public service:CardPaymentService, private toastr:ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    if(this.service.formData.id == 0){
      this.insertRecord(form);
    }else{
      this.updateRecord(form);
    }
  }

  insertRecord(form:NgForm){
    this.service.postCardDetail().subscribe(
      res =>{
        this.resetForm(form);
        this.service.getCardList();
        this.toastr.success("Submitted successfully", "Card Details");
      },
      err => {
        console.log(err);
      }
    );
  }

  updateRecord(form:NgForm){
    this.service.putCardDetail().subscribe(
      res =>{
        this.resetForm(form);
        this.service.getCardList();
        this.toastr.success("Updated successfully", "Card Details");
      },
      err => {
        this.resetForm(form);
        this.toastr.error("Update unsuccessful", "Card Details");
        console.log(err);
      }
    );
  }

  resetForm(form:NgForm){
    form.form.reset();
    this.service.formData = new CardPayment();
  }

}
