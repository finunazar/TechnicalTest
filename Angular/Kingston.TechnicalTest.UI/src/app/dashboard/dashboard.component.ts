import { Component } from '@angular/core';
import { MathsandrandomService } from '../services/mathsandrandom.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {

  flagSuccess:boolean=false;
  flagFailure:boolean=false;
  displayFlag:boolean=false;
  numberAndRandomOptions:string[]=["Prime Numbers", "Fibonacci Numbers", "Random Characters"]
  selectedOption:string="Prime Numbers";
  x_val?:number;
  y_val?:number;
  result1:number[]=[];
  result2:string[]=[];
  msg:string="";
  response:string=""
  constructor(private service:MathsandrandomService)
  {

  }
  nextCard()
  {
    this.displayFlag = true;
  }

  generateList()
  {
    console.log(this.x_val);
    console.log(this.y_val);
    this.flagFailure = false;
    this.flagSuccess = false;
    if(this.selectedOption == "Prime Numbers")
    {
      this.service.generatePrimeNumbers(this.x_val, this.y_val)
      .subscribe({
        next: (v) => {console.log(v), this.result1 = v as number[], this.convertResult(this.result1)},
        error: (e) => {console.log(e), this.flagFailure =true, this.msg= e as string},
        complete: () => {console.info('registration complete')} 
      })
    }
    else if (this.selectedOption == "Fibonacci Numbers")
    {
      this.service.generateFibonacciNumbers(this.x_val, this.y_val)
      .subscribe({
        next: (v) => {console.log(v), this.result1 = v as number[], this.convertResult(this.result1)},
        error: (e) => {console.log(e), this.flagFailure =true, this.msg= e as string},
        complete: () => {console.info('registration complete')} 
      })
    }
    else if (this.selectedOption == "Random Characters")
    {
      this.service.getRandomCharacters(this.x_val, this.y_val)
      .subscribe({
        next: (v) => {console.log(v), this.result2 = v as string[], this.convertResult(this.result2)},
        error: (e) => {console.log(e), this.flagFailure =true, this.msg= e as string},
        complete: () => {console.info('registration complete')} 
      })
    }
  }

  convertResult(data:any)
  {
    this.response = data.join(', ');
    this.flagSuccess=true
    console.log(this.response)
  }
}
