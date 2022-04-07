using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobembo.cd_Back_c____.Migrations
{
    public partial class premiere_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactPersonne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPersonne", x => x.Id);
                    table.CheckConstraint("CheckMinMail", "LEN(Email)>=6");
                });

            migrationBuilder.CreateTable(
                name: "PassWord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mdp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassWord", x => x.Id);
                    table.CheckConstraint("CheckMinMail1", "LEN(Mdp)>=6");
                });

            migrationBuilder.CreateTable(
                name: "RolePersonne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePersonne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ddn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RolePersonneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personne", x => x.Id);
                    table.CheckConstraint("CheckAdult", "DateDiff(year, Ddn, GetDate())>=18");
                    table.CheckConstraint("CheckMinNom", "LEN(Prenom)>=3");
                    table.ForeignKey(
                        name: "FK_Contact_Personne",
                        column: x => x.Id,
                        principalTable: "ContactPersonne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personne_PassWord_Id",
                        column: x => x.Id,
                        principalTable: "PassWord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personne_RolePersonne_RolePersonneId",
                        column: x => x.RolePersonneId,
                        principalTable: "RolePersonne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactPersonne_Email",
                table: "ContactPersonne",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personne_RolePersonneId",
                table: "Personne",
                column: "RolePersonneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personne");

            migrationBuilder.DropTable(
                name: "ContactPersonne");

            migrationBuilder.DropTable(
                name: "PassWord");

            migrationBuilder.DropTable(
                name: "RolePersonne");
        }
    }
}
