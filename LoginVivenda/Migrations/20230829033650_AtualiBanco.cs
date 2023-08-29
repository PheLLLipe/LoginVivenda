using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginVivenda.Migrations
{
    public partial class AtualiBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartaPDF",
                table: "Candidato");

            migrationBuilder.AlterColumn<string>(
                name: "Horario",
                table: "Vagas",
                type: "character varying(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(5)",
                oldMaxLength: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Horario",
                table: "Vagas",
                type: "character varying(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(14)",
                oldMaxLength: 14);

            migrationBuilder.AddColumn<string>(
                name: "CartaPDF",
                table: "Candidato",
                type: "text",
                nullable: true);
        }
    }
}
