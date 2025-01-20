import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lancamentos',
  templateUrl: './lancamentos.component.html',
  styleUrls: ['./lancamentos.component.scss']
})
export class LancamentosComponent implements OnInit {

public lancamentos: any;

public getLancamentos() : void {

    this.http.get("https://localhost:5001/api/lancamentos").subscribe(
      response => this.lancamentos = response,
      error => console.log(error)
    );
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getLancamentos();
  }
}
