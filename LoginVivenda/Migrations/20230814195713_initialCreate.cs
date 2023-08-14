using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LoginVivenda.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CEP = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    UF = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Cidade = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Bairro = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Rua = table.Column<string>(type: "character varying(65)", maxLength: 65, nullable: false),
                    Numero = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true),
                    Complemento = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "formacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Instituto = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    Nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DataIni = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataFim = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Curso = table.Column<int>(type: "integer", nullable: false),
                    Cidade = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vaga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Horario = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    Cargo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vaga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    CNPJ = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Telefone = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Contato = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "endereco",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Candidatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VagaId = table.Column<int>(type: "integer", nullable: true),
                    CandidatoId = table.Column<int>(type: "integer", nullable: true),
                    Mensagem = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Notas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidatura_Candidato_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidato",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Candidatura_vaga_VagaId",
                        column: x => x.VagaId,
                        principalTable: "vaga",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_CandidatoId",
                table: "Candidatura",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_VagaId",
                table: "Candidatura",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_EnderecoId",
                table: "empresa",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatura");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "formacao");

            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.DropTable(
                name: "vaga");

            migrationBuilder.DropTable(
                name: "endereco");
        }
    }
}
