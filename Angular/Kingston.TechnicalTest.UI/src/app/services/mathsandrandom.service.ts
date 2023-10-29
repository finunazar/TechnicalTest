import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class MathsandrandomService {

  readonly rootUrl = 'http://localhost:5265/api/MathAndRandom';
  constructor(private http: HttpClient,private router: Router) { }

  generatePrimeNumbers(x?:number, y?:number)
  {
      return this.http.get(this.rootUrl+'/PrimeNumbers?x='+x+"&y="+y ,{ headers: this.getHeaders() })
  }

  generateFibonacciNumbers(x?:number, y?:number)
  {
      return this.http.get(this.rootUrl+'/FibonacciNumbers?x='+x+"&y="+y ,{ headers: this.getHeaders() })
  }

  getRandomCharacters(x?:number, y?:number)
  {
      return this.http.get(this.rootUrl+'/RandomCharacters?x='+x+"&y="+y ,{ headers: this.getHeaders() })
  }

  getHeaders():HttpHeaders
  {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json'
    })
    return headers;
  }
}
