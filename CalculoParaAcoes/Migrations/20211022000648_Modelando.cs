using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalculoParaAcoesMVC.Migrations
{
    public partial class Modelando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DesvioPadrao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDaAcao = table.Column<string>(nullable: false),
                    FechamentoAtual = table.Column<string>(nullable: false),
                    Abertura1Antes = table.Column<string>(nullable: false),
                    DesvPadrao = table.Column<string>(nullable: false),
                    DataCriado = table.Column<DateTime>(nullable: false),
                    Desvio1 = table.Column<double>(nullable: false),
                    Desvio2 = table.Column<double>(nullable: false),
                    Desvio1n = table.Column<double>(nullable: false),
                    Desvio2n = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesvioPadrao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zscore",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDaAcao = table.Column<string>(nullable: false),
                    Variacao5Anos = table.Column<string>(nullable: false),
                    Dias = table.Column<int>(nullable: false),
                    DiasUteis = table.Column<int>(nullable: false),
                    PrecoAberturaMes = table.Column<string>(nullable: false),
                    Ewma = table.Column<string>(nullable: false),
                    PrecoAtual = table.Column<string>(nullable: false),
                    ValorZscore = table.Column<double>(nullable: false),
                    AcimaValorAtual = table.Column<double>(nullable: false),
                    AbaixoValorAtual = table.Column<double>(nullable: false),
                    DataCriado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zscore", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesvioPadrao");

            migrationBuilder.DropTable(
                name: "Zscore");
        }
    }
}
