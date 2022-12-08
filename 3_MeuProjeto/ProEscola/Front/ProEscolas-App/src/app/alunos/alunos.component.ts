import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.scss']
})
export class AlunosComponent implements OnInit {

  public alunos: any = [];
  public alunosFiltrados: any = [];
  larguraImg: number = 55;
  margemImg: number = 5;
  exibirImagem:boolean = true;
  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.alunosFiltrados = this.filtroLista ? this.filtrarAlunos(this.filtroLista) : this.alunos;
  }

  filtrarAlunos(filtrarPor: string) : any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.alunos.filter(
      (aluno: any) => aluno.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
                      aluno.email.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getAlunos();
  }

  alterarEstadoImagem(){
    this.exibirImagem = !this.exibirImagem;
  }

  public getAlunos(): void{
    this.http.get('https://localhost:5001/api/Alunos').subscribe(
      response => {
        this.alunos = response;
        this.alunosFiltrados = this.alunos;
      },
      error => console.log(error)
    )
  }

}
