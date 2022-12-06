import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.scss']
})
export class AlunosComponent implements OnInit {

  public alunos : any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getAlunos();
  }

  public getAlunos(): void{
    this.http.get('https://localhost:5001/api/Alunos').subscribe(
      response => this.alunos = response,
      error => console.log(error)
    );
  }

}
