using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMDS.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abonamente",
                columns: table => new
                {
                    abonamentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tip = table.Column<string>(nullable: true),
                    pret = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonamente", x => x.abonamentId);
                });

            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    clientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nume = table.Column<string>(nullable: true),
                    prenume = table.Column<string>(nullable: true),
                    numarTelefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.clientId);
                });

            migrationBuilder.CreateTable(
                name: "Suplimente",
                columns: table => new
                {
                    suplimentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    denumire = table.Column<string>(nullable: true),
                    pret = table.Column<double>(nullable: false),
                    tip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplimente", x => x.suplimentId);
                });

            migrationBuilder.CreateTable(
                name: "Angajati",
                columns: table => new
                {
                    angajatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nume = table.Column<string>(nullable: true),
                    prenume = table.Column<string>(nullable: true),
                    salariu = table.Column<double>(nullable: false),
                    numarTelefon = table.Column<string>(nullable: true),
                    abonamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Angajati", x => x.angajatId);
                    table.ForeignKey(
                        name: "FK_Angajati_Abonamente_abonamentId",
                        column: x => x.abonamentId,
                        principalTable: "Abonamente",
                        principalColumn: "abonamentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientAbonamente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    clientId = table.Column<int>(nullable: false),
                    abonamentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAbonamente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientAbonamente_Abonamente_abonamentId",
                        column: x => x.abonamentId,
                        principalTable: "Abonamente",
                        principalColumn: "abonamentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientAbonamente_Clienti_clientId",
                        column: x => x.clientId,
                        principalTable: "Clienti",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientSuplimente",
                columns: table => new
                {
                    clientSuplimentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    clientId = table.Column<int>(nullable: false),
                    suplimentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSuplimente", x => x.clientSuplimentId);
                    table.ForeignKey(
                        name: "FK_ClientSuplimente_Clienti_clientId",
                        column: x => x.clientId,
                        principalTable: "Clienti",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientSuplimente_Suplimente_suplimentId",
                        column: x => x.suplimentId,
                        principalTable: "Suplimente",
                        principalColumn: "suplimentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Angajati_abonamentId",
                table: "Angajati",
                column: "abonamentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientAbonamente_abonamentId",
                table: "ClientAbonamente",
                column: "abonamentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientAbonamente_clientId",
                table: "ClientAbonamente",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSuplimente_clientId",
                table: "ClientSuplimente",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSuplimente_suplimentId",
                table: "ClientSuplimente",
                column: "suplimentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Angajati");

            migrationBuilder.DropTable(
                name: "ClientAbonamente");

            migrationBuilder.DropTable(
                name: "ClientSuplimente");

            migrationBuilder.DropTable(
                name: "Abonamente");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "Suplimente");
        }
    }
}
