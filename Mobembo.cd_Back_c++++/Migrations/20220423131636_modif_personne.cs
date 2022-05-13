using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobembo.cd_Back_c____.Migrations
{
    public partial class modif_personne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumCompte",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Null",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NumCarte",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Null",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NomBanque",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Null",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumCompte",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Null");

            migrationBuilder.AlterColumn<string>(
                name: "NumCarte",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Null");

            migrationBuilder.AlterColumn<string>(
                name: "NomBanque",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Null");
        }
    }
}
