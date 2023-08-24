using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginVivenda.Migrations
{
    public partial class AtualizacaoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidatoId",
                table: "Formação",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contato",
                table: "Empresa",
                type: "character varying(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidato",
                type: "character varying(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Candidato",
                type: "character varying(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CartaPDF",
                table: "Candidato",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Civil",
                table: "Candidato",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CurriculoPdf",
                table: "Candidato",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Deficiencia",
                table: "Candidato",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Candidato",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Candidato",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Habilidades",
                table: "Candidato",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoadedFromDatabase",
                table: "Candidato",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nacionalidade",
                table: "Candidato",
                type: "character varying(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Objetivo",
                table: "Candidato",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Qual",
                table: "Candidato",
                type: "character varying(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Candidato",
                type: "character varying(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone2",
                table: "Candidato",
                type: "character varying(11)",
                maxLength: 11,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Formação_CandidatoId",
                table: "Formação",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_EnderecoId",
                table: "Candidato",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidato_Endereço_EnderecoId",
                table: "Candidato",
                column: "EnderecoId",
                principalTable: "Endereço",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Formação_Candidato_CandidatoId",
                table: "Formação",
                column: "CandidatoId",
                principalTable: "Candidato",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidato_Endereço_EnderecoId",
                table: "Candidato");

            migrationBuilder.DropForeignKey(
                name: "FK_Formação_Candidato_CandidatoId",
                table: "Formação");

            migrationBuilder.DropIndex(
                name: "IX_Formação_CandidatoId",
                table: "Formação");

            migrationBuilder.DropIndex(
                name: "IX_Candidato_EnderecoId",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "CandidatoId",
                table: "Formação");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "CartaPDF",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Civil",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "CurriculoPdf",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Deficiencia",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Habilidades",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "LoadedFromDatabase",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Nacionalidade",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Objetivo",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Qual",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "Telefone2",
                table: "Candidato");

            migrationBuilder.AlterColumn<string>(
                name: "Contato",
                table: "Empresa",
                type: "character varying(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidato",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(70)",
                oldMaxLength: 70);
        }
    }
}
