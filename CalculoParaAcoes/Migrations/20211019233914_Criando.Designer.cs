﻿// <auto-generated />
using System;
using CalculoParaAcoes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CalculoParaAcoesMVC.Migrations
{
    [DbContext(typeof(CalculosDbContext))]
    [Migration("20211019233914_Criando")]
    partial class Criando
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CalculoParaAcoes.Models.DesvioPadrao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Abertura1Antes");

                    b.Property<DateTime>("DataCriado");

                    b.Property<double>("DesvPadrao");

                    b.Property<double>("FechamentoAtual");

                    b.HasKey("Id");

                    b.ToTable("DesvioPadrao");
                });

            modelBuilder.Entity("CalculoParaAcoes.Models.Zscore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AbaixoValorAtual");

                    b.Property<double>("AcimaValorAtual");

                    b.Property<DateTime>("DataCriado");

                    b.Property<int>("Dias");

                    b.Property<int>("DiasUteis");

                    b.Property<double>("Ewma");

                    b.Property<string>("NomeDaAcao")
                        .IsRequired();

                    b.Property<double>("PrecoAberturaMes");

                    b.Property<double>("PrecoAtual");

                    b.Property<double>("ValorZscore");

                    b.Property<double>("Variacao5Anos");

                    b.HasKey("Id");

                    b.ToTable("Zscore");
                });
#pragma warning restore 612, 618
        }
    }
}
