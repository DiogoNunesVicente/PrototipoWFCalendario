﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SisCalenderVicente.Data;

#nullable disable

namespace SisCalenderVicente.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240920011254_Tabela_Evento")]
    partial class Tabela_Evento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("SisCalenderVicente.Modelos.Evento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
