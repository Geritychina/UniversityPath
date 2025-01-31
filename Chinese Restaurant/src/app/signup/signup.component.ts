import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  signUpForm!: FormGroup;
  constructor(private formBuider: FormBuilder, private _http: HttpClient, private router: Router) { }

  ngOnInit(): void {
    this.signUpForm = this.formBuider.group({
      name: [''],
      email: [''],
      mobile: [''],
      password: ['']
    })
  }

  //Sign Up Method
  signUp() {
    this._http.post<any>("http://localhost:3000/signup", this.signUpForm.value).subscribe(res => {
      alert("User successfuly registered!");
      this.signUpForm.reset();
      this.router.navigate(['login']);
    },
      err => {
        alert("Opps, can't sign up!");
      })
  }

}
