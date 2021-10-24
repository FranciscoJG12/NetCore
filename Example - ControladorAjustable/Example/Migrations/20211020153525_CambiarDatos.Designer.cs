﻿// <auto-generated />
using Example.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Example.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211020153525_CambiarDatos")]
    partial class CambiarDatos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Example.Models.Amigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amigos");

                    b.HasData(
                        new
                        {
                            Id = 10000,
                            Ciudad = "WirriLandia",
                            Email = "wirri@gmail.com",
                            Nombre = "Wirri Girl"
                        },
                        new
                        {
                            Id = 2000,
                            Ciudad = "AntoineLandia",
                            Email = "antoine@gmail.com",
                            Nombre = "Antoine"
                        },
                        new
                        {
                            Id = 3000,
                            Ciudad = "FrancoLandia",
                            Email = "francisco@gmail.com",
                            Nombre = "Francisco"
                        },
                        new
                        {
                            Id = 4000,
                            Ciudad = "PierreLandia",
                            Email = "pierre@gmail.com",
                            Nombre = "Pierre"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}