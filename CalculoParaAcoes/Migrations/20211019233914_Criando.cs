using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalculoParaAcoesMVC.Migrations
{
    public partial class Criando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DesvioPadrao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCriado = table.Column<DateTime>(nullable: false),
                    FechamentoAtual = table.Column<double>(nullable: false),
                    Abertura1Antes = table.Column<double>(nullable: false),
                    DesvPadrao = table.Column<double>(nullable: false)
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
                    Variacao5Anos = table.Column<double>(nullable: false),
                    Dias = table.Column<int>(nullable: false),
                    DiasUteis = table.Column<int>(nullable: false),
                    PrecoAberturaMes = table.Column<double>(nullable: false),
                    Ewma = table.Column<double>(nullable: false),
                    PrecoAtual = table.Column<double>(nullable: false),
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
