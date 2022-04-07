using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobembo.cd_Back_c____.Migrations
{
    public partial class ajou_Admin_Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomRole",
                table: "RolePersonne",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Client",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "RolePersonne",
                columns: new[] { "Id", "NomRole" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "RolePersonne",
                columns: new[] { "Id", "NomRole" },
                values: new object[] { 2, "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePersonne",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RolePersonne",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "NomRole",
                table: "RolePersonne",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Client");
        }
    }
}
