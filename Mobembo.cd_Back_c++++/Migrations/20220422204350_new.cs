using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobembo.cd_Back_c____.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlaDisposition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomDuDisponible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disposition", x => x.Id);
                    table.CheckConstraint("CheckMinMail", "LEN(NomDuDisponible)>=2");
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Alpha2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Alpha3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NomEnGb = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NomFrFr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ddn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mdp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomBanque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumCarte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumCompte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personne", x => x.Id);
                    table.CheckConstraint("CheckAdult", "DateDiff(year, Ddn, GetDate())>=18");
                    table.CheckConstraint("CheckMinMail1", "LEN(Email)>=6");
                    table.CheckConstraint("CheckMinNom", "LEN(Prenom)>=3");
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomProvince = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_province", x => x.Id);
                    table.CheckConstraint("CheckMinMail2", "LEN(Description)>=50");
                });

            migrationBuilder.CreateTable(
                name: "RolePersonne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomRole = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Client")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePersonne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeBien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_bien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdressePersonne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NumHabitation = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NomRue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodePostalLocalite = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adresse_personne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdressePersonne_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdressePersonne_Personne_Id",
                        column: x => x.Id,
                        principalTable: "Personne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomVille = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NHabitant = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ville", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ville_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonneRoles",
                columns: table => new
                {
                    PersonneId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonneRoles", x => new { x.RoleId, x.PersonneId });
                    table.ForeignKey(
                        name: "FK_PersonneRoles_Personne_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonneRoles_RolePersonne_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RolePersonne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coordonnee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VilleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coordonnee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordonnee_Ville_VilleID",
                        column: x => x.VilleID,
                        principalTable: "Ville",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeBienId = table.Column<int>(type: "int", nullable: false),
                    CoordonneeId = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<int>(type: "int", nullable: false),
                    NPMin = table.Column<int>(type: "int", nullable: false),
                    NPMax = table.Column<int>(type: "int", nullable: false),
                    NChambre = table.Column<int>(type: "int", nullable: false),
                    NSDB = table.Column<int>(type: "int", nullable: false),
                    NWC = table.Column<int>(type: "int", nullable: false),
                    Superficie = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppartientAId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bien_Coordonnee_CoordonneeId",
                        column: x => x.CoordonneeId,
                        principalTable: "Coordonnee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bien_Personne_AppartientAId",
                        column: x => x.AppartientAId,
                        principalTable: "Personne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bien_TypeBien_TypeBienId",
                        column: x => x.TypeBienId,
                        principalTable: "TypeBien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aLaDispositionBiens",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "int", nullable: false),
                    ALaDispositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aLaDispositionBiens", x => new { x.BienId, x.ALaDispositionId });
                    table.ForeignKey(
                        name: "FK_aLaDispositionBiens_AlaDisposition_ALaDispositionId",
                        column: x => x.ALaDispositionId,
                        principalTable: "AlaDisposition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aLaDispositionBiens_Bien_BienId",
                        column: x => x.BienId,
                        principalTable: "Bien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RolePersonne",
                columns: new[] { "Id", "NomRole" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "RolePersonne",
                columns: new[] { "Id", "NomRole" },
                values: new object[] { 2, "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_AdressePersonne_PaysId",
                table: "AdressePersonne",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_AlaDisposition_NomDuDisponible",
                table: "AlaDisposition",
                column: "NomDuDisponible",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aLaDispositionBiens_ALaDispositionId",
                table: "aLaDispositionBiens",
                column: "ALaDispositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bien_AppartientAId",
                table: "Bien",
                column: "AppartientAId");

            migrationBuilder.CreateIndex(
                name: "IX_Bien_CoordonneeId",
                table: "Bien",
                column: "CoordonneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bien_TypeBienId",
                table: "Bien",
                column: "TypeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordonnee_VilleID",
                table: "Coordonnee",
                column: "VilleID");

            migrationBuilder.CreateIndex(
                name: "IX_Personne_Email",
                table: "Personne",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonneRoles_PersonneId",
                table: "PersonneRoles",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Ville_ProvinceId",
                table: "Ville",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdressePersonne");

            migrationBuilder.DropTable(
                name: "aLaDispositionBiens");

            migrationBuilder.DropTable(
                name: "PersonneRoles");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropTable(
                name: "AlaDisposition");

            migrationBuilder.DropTable(
                name: "Bien");

            migrationBuilder.DropTable(
                name: "RolePersonne");

            migrationBuilder.DropTable(
                name: "Coordonnee");

            migrationBuilder.DropTable(
                name: "Personne");

            migrationBuilder.DropTable(
                name: "TypeBien");

            migrationBuilder.DropTable(
                name: "Ville");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
