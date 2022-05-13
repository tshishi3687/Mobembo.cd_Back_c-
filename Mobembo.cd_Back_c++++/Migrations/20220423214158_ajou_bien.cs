using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobembo.cd_Back_c____.Migrations
{
    public partial class ajou_bien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CheckMinMail2",
                table: "Province");

            migrationBuilder.DropCheckConstraint(
                name: "CheckMinMail1",
                table: "Personne");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Bien",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddCheckConstraint(
                name: "CheckMinMail3",
                table: "Province",
                sql: "LEN(Description)>=50");

            migrationBuilder.AddCheckConstraint(
                name: "CheckMinMail2",
                table: "Personne",
                sql: "LEN(Email)>=6");

            migrationBuilder.AddCheckConstraint(
                name: "CheckMinMail1",
                table: "Bien",
                sql: "LEN(Description)>=50");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CheckMinMail3",
                table: "Province");

            migrationBuilder.DropCheckConstraint(
                name: "CheckMinMail2",
                table: "Personne");

            migrationBuilder.DropCheckConstraint(
                name: "CheckMinMail1",
                table: "Bien");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Bien",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddCheckConstraint(
                name: "CheckMinMail2",
                table: "Province",
                sql: "LEN(Description)>=50");

            migrationBuilder.AddCheckConstraint(
                name: "CheckMinMail1",
                table: "Personne",
                sql: "LEN(Email)>=6");
        }
    }
}
