import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AlunosComponent } from './alunos/alunos.component';
import { AprazosComponent } from './aprazos/aprazos.component';
import { AvistasComponent } from './avistas/avistas.component';
import { CursosComponent } from './cursos/cursos.component';
import { InstrutoresComponent } from './instrutores/instrutores.component';
import { MatriculasComponent } from './matriculas/matriculas.component';
import { TurmasComponent } from './turmas/turmas.component';

@NgModule({
  declarations: [
    AppComponent,
    AlunosComponent,
    AprazosComponent,
    AvistasComponent,
    CursosComponent,
    InstrutoresComponent,
    MatriculasComponent,
    TurmasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
