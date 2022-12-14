using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEscolas.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Escolaridade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNasc = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celular = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoCivil = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rg = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sigla = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CargaHoraria = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    DataVigencia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorHoraInstrutor = table.Column<double>(type: "double", nullable: false),
                    Programa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instrutores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Formacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AreaAtuacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNasc = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celular = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoCivil = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rg = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrutores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SiglaTurma = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataInicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataTermino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Periodo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QtdeVagas = table.Column<int>(type: "int", nullable: false),
                    Observacoes = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InstrutorId = table.Column<int>(type: "int", nullable: true),
                    CursoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turmas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Turmas_Instrutores_InstrutorId",
                        column: x => x.InstrutorId,
                        principalTable: "Instrutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QtdeFaltas = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<double>(type: "double", nullable: false),
                    AlunoId = table.Column<int>(type: "int", nullable: true),
                    TurmaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matriculas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Aprazos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    DtVencimento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QtdeMensalidade = table.Column<int>(type: "int", nullable: false),
                    TaxaJuros = table.Column<double>(type: "double", nullable: false),
                    MatriculaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aprazos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aprazos_Matriculas_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Matriculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Avistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    Agencia = table.Column<int>(type: "int", nullable: false),
                    NCheque = table.Column<int>(type: "int", nullable: false),
                    PreData = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MatriculaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avistas_Matriculas_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Matriculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Bairro", "Celular", "Cep", "Cidade", "Cpf", "DataNasc", "Email", "Endereco", "Escolaridade", "Estado", "EstadoCivil", "Nome", "Numero", "Rg", "Sexo", "Telefone" },
                values: new object[,]
                {
                    { 1, "Centro", "11922211111", "11222-111", "Itu", "123.456.789-22", "01/09/2000", "teste2@teste.com", "Rua AA", "Ensino Médio", "SP", "Casado", "João", 17, "11.111.222-22", "M", "5555511111" },
                    { 2, "Centro", "33911111111", "31111-111", "Itu", "012.645.201-77", "01/01/1990", "teste3@teste.com", "Rua M", "Ensino Superior", "RJ", "Solteiro", "Marcio", 15, "33.111.111-11", "M", "3311111111" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "CargaHoraria", "DataVigencia", "Nome", "Programa", "Sigla", "Valor", "ValorHoraInstrutor" },
                values: new object[,]
                {
                    { 1, 20, "02/03/2022", "Analista", "Planilhas", "AAA", 850.29999999999995, 125.3 },
                    { 2, 30, "22/10/2022", "Junior", "Residêncial", "BBC", 743.20000000000005, 100.59999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Instrutores",
                columns: new[] { "Id", "AreaAtuacao", "Bairro", "Celular", "Cep", "Cidade", "Cpf", "DataNasc", "Email", "Endereco", "Estado", "EstadoCivil", "Formacao", "Nome", "Numero", "Rg", "Sexo", "Telefone" },
                values: new object[,]
                {
                    { 1, "Administração", "Centro", "11911111111", "11111-111", "Sorocaba", "1", "01/01/2000", "teste1@teste.com", "Rua J", "RJ", "Solteiro", "Ensino Médio", "Roberto", 10, "11.111.111-11", "M", "1111111111" },
                    { 2, "Eletrecista", "Centro", "22911111111", "22222-111", "Jundiaí", "2", "01/01/2001", "teste2@teste.com", "Rua A", "SP", "Solteiro", "Ensino Fundamental", "Ana", 101, "11.111.111-22", "F", "2211111111" }
                });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "Id", "CursoId", "DataInicio", "DataTermino", "Descricao", "InstrutorId", "Observacoes", "Periodo", "QtdeVagas", "SiglaTurma" },
                values: new object[] { 1, 1, "02/02/2022", "02/10/2022", "Analistas de Sistemas", 1, "Terá um mês de férias.", "Manhã", 20, "AA10" });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "Id", "CursoId", "DataInicio", "DataTermino", "Descricao", "InstrutorId", "Observacoes", "Periodo", "QtdeVagas", "SiglaTurma" },
                values: new object[] { 2, 2, "02/03/2022", "02/06/2022", "Bolos e Confeitos", 2, "Não terá um mês de férias.", "Tarde", 5, "BB01" });

            migrationBuilder.InsertData(
                table: "Matriculas",
                columns: new[] { "Id", "AlunoId", "Data", "Nota", "QtdeFaltas", "TurmaId" },
                values: new object[] { 1, 2, "14/12/2022 16:42:30", 7.7999999999999998, 7, 1 });

            migrationBuilder.InsertData(
                table: "Matriculas",
                columns: new[] { "Id", "AlunoId", "Data", "Nota", "QtdeFaltas", "TurmaId" },
                values: new object[] { 2, 1, "14/12/2022 16:42:30", 2.6000000000000001, 3, 2 });

            migrationBuilder.InsertData(
                table: "Aprazos",
                columns: new[] { "Id", "DtVencimento", "MatriculaId", "QtdeMensalidade", "TaxaJuros", "Valor" },
                values: new object[] { 1, "05/05/2022", 1, 3, 5.5999999999999996, 322.60000000000002 });

            migrationBuilder.InsertData(
                table: "Aprazos",
                columns: new[] { "Id", "DtVencimento", "MatriculaId", "QtdeMensalidade", "TaxaJuros", "Valor" },
                values: new object[] { 2, "05/05/2022", 2, 3, 5.5999999999999996, 322.60000000000002 });

            migrationBuilder.CreateIndex(
                name: "IX_Aprazos_MatriculaId",
                table: "Aprazos",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Avistas_MatriculaId",
                table: "Avistas",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_AlunoId",
                table: "Matriculas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_TurmaId",
                table: "Matriculas",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_CursoId",
                table: "Turmas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_InstrutorId",
                table: "Turmas",
                column: "InstrutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aprazos");

            migrationBuilder.DropTable(
                name: "Avistas");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Instrutores");
        }
    }
}
