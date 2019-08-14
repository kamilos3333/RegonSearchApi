using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegonSearchApi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<Guid>(nullable: false),
                    CompanyDetailID = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    REGON = table.Column<string>(nullable: true),
                    KRS = table.Column<string>(nullable: true),
                    NIP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Companies_CompanyDetails_CompanyDetailID",
                        column: x => x.CompanyDetailID,
                        principalTable: "CompanyDetails",
                        principalColumn: "CompanyDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Voivodeships",
                columns: new[] { "VoivodeshipID", "NameVoivodeship" },
                values: new object[,]
                {
                    { new Guid("242a57d2-89b6-4cd5-bba3-17c0796d57c7"), "dolnośląskie" },
                    { new Guid("8b25122f-8667-4224-940b-c8c7e3a7f6ec"), "kujawsko-pomorskie" },
                    { new Guid("4af0cbd5-d35d-43c0-81e4-a56e5fa6c78a"), "lubelskie" },
                    { new Guid("a81dc8b1-915e-4a2e-8d36-e5724f7933f0"), "lubulskie" },
                    { new Guid("0c4fad76-822b-4048-a6ab-ddbe2b07fcba"), "łódzkie" },
                    { new Guid("ca72d518-6b27-46a8-8086-570fd0c9c433"), "małopolskie" },
                    { new Guid("4674fedd-399f-4dd6-abdf-dbacf801f34d"), "mazowieckie" },
                    { new Guid("7f808e29-7863-43d8-ab0d-7294475a4a42"), "opolskie" },
                    { new Guid("af866bfb-a1ef-456f-bb53-0811a3b6fd6d"), "podkarpackie" },
                    { new Guid("625e6a5b-40e4-4337-a315-d4fd2f2a4408"), "podlaskie" },
                    { new Guid("a0f11602-8d86-429a-9e77-7cec71bd2d11"), "pomorskie" },
                    { new Guid("3d7950c3-693c-42c2-a975-0bc1bb572f8e"), "śląskie" },
                    { new Guid("f011d8cc-db4c-4165-8d61-8f8408286f36"), "świętokrzyskie" },
                    { new Guid("e857b3e0-99f3-4ff0-b924-b7074c82947d"), "warmińsko-mazurskie" },
                    { new Guid("1ad19f6a-070b-46f6-aff9-61667bbe2de7"), "wielkopolskie" },
                    { new Guid("5687bbe7-08b9-4744-b62f-4a14f4ecbaf8"), "zachodniopomorskie" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "PostalCode", "VoivodeshipID" },
                values: new object[,]
                {
                    { new Guid("898cea68-0ead-44d7-bd18-153de6e9c0a3"), "Wrocław", "50-001", new Guid("242a57d2-89b6-4cd5-bba3-17c0796d57c7") },
                    { new Guid("697d4e2d-81b5-4534-ab9b-c3973067e44f"), "Bydgoszcz", "85-001", new Guid("8b25122f-8667-4224-940b-c8c7e3a7f6ec") },
                    { new Guid("ab48ffb4-cf77-41de-8cab-5f910facd057"), "Lublin", "20-001", new Guid("a81dc8b1-915e-4a2e-8d36-e5724f7933f0") },
                    { new Guid("2e43a9c2-7a8e-47f2-aa8c-b3b8afbfa53d"), "Łódź", "90-001", new Guid("0c4fad76-822b-4048-a6ab-ddbe2b07fcba") },
                    { new Guid("0cdb8b1d-af2f-4152-b3c2-5127a26b3d09"), "Kraków", "30-001", new Guid("ca72d518-6b27-46a8-8086-570fd0c9c433") },
                    { new Guid("7f7fe442-017c-4a9c-ad2c-e796d9b6766c"), "Warszawa", "00-004", new Guid("4674fedd-399f-4dd6-abdf-dbacf801f34d") },
                    { new Guid("cba9b6f1-5525-4db0-bf12-cf7c5be75119"), "Radom", "26-600 ", new Guid("4674fedd-399f-4dd6-abdf-dbacf801f34d") },
                    { new Guid("22b495f0-13a3-4e32-a392-a7580e8aa056"), "Białystok", "15-001", new Guid("625e6a5b-40e4-4337-a315-d4fd2f2a4408") },
                    { new Guid("851c78ed-3c17-4615-a4ff-3b8397bc2690"), "Gdańsk", "80-008", new Guid("a0f11602-8d86-429a-9e77-7cec71bd2d11") },
                    { new Guid("e47ce57a-5d4d-41d2-9489-a799260dedd6"), "Gdynia", "81-000", new Guid("a0f11602-8d86-429a-9e77-7cec71bd2d11") },
                    { new Guid("cf1f0746-7168-44b1-8fa6-38b6594a4a11"), "Katowice", "40-001", new Guid("3d7950c3-693c-42c2-a975-0bc1bb572f8e") },
                    { new Guid("527dc626-9cb4-4a19-bd44-f18a9f1821bf"), "Częstochowa", "42-200", new Guid("3d7950c3-693c-42c2-a975-0bc1bb572f8e") },
                    { new Guid("456214cc-8a84-403c-a8a9-e663930aba96"), "Poznań", "60-001", new Guid("1ad19f6a-070b-46f6-aff9-61667bbe2de7") },
                    { new Guid("5ab5c3bc-d446-4982-b9fe-597d33afdd0b"), "Szczecin", "70-001", new Guid("5687bbe7-08b9-4744-b62f-4a14f4ecbaf8") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_VoivodeshipID",
                table: "Cities",
                column: "VoivodeshipID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyDetailID",
                table: "Companies",
                column: "CompanyDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_CityID",
                table: "CompanyDetails",
                column: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "CompanyDetails");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Voivodeships");
        }
    }
}
