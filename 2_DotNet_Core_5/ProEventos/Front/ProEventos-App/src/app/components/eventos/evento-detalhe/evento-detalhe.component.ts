import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-evento-detalhe',
  templateUrl: './evento-detalhe.component.html',
  styleUrls: ['./evento-detalhe.component.scss']
})
export class EventoDetalheComponent implements OnInit {
  //form: FormGroup;

  constructor(private fb: FormBuilder) {
    //this.form = new FormGroup();
  }

  ngOnInit(): void {
    //this.validation();
  }

  //public validation() : void{
  //  this.form = this.fb.group({
  //    tema: ['',[Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
  //    local: ['',Validators.required],
  //    dataEvento: ['', Validators.required],
  //    qtdePessoas: ['',[Validators.required, Validators.minLength(120000)]],
  //    imagemUrl: ['', Validators.required],
  //    telefone: ['',Validators.required],
  //    email: ['',[Validators.required, Validators.email]],
  //  });
  //}

}
