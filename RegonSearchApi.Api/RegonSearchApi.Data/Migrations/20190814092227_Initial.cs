using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegonSearchApi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    REGON = table.Column<string>(nullable: true),
                    KRS = table.Column<string>(nullable: true),
                    NIP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Voivodeships",
                columns: table => new
                {
                    VoivodeshipID = table.Column<Guid>(nullable: false),
                    NameVoivodeship = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voivodeships", x => x.VoivodeshipID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<Guid>(nullable: false),
                    VoivodeshipID = table.Column<Guid>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_Cities_Voivodeships_VoivodeshipID",
                        column: x => x.VoivodeshipID,
                        principalTable: "Voivodeships",
                        principalColumn: "VoivodeshipID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyDetails",
                columns: table => new
                {
                    CompanyDetailID = table.Column<Guid>(nullable: false),
                    CompanyID = table.Column<Guid>(nullable: false),
                    CityID = table.Column<Guid>(nullable: false),
                    Adress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDetails", x => x.CompanyDetailID);
                    table.ForeignKey(
                        name: "FK_CompanyDetails_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyDetails_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_VoivodeshipID",
                table: "Cities",
                column: "VoivodeshipID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_CityID",
                table: "CompanyDetails",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_CompanyID",
                table: "CompanyDetails",
                column: "CompanyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyDetails");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Voivodeships");
        }
    }
}
