﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORM_LocadoraDeVeiculos;

#nullable disable

namespace ORM_LocadoraDeVeiculos.Migrations
{
    [DbContext(typeof(Program.ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ORM_LocadoraDeVeiculos.Program+Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ORM_LocadoraDeVeiculos.Program+Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("DataDevolucao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataRetirada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteID");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("ORM_LocadoraDeVeiculos.Program+Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Alugado")
                        .HasColumnType("bit");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservaID")
                        .HasColumnType("int");

                    b.Property<float>("ValorDiaria")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("ORM_LocadoraDeVeiculos.Program+Reserva", b =>
                {
                    b.HasOne("ORM_LocadoraDeVeiculos.Program+Cliente", null)
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteID");
                });

            modelBuilder.Entity("ORM_LocadoraDeVeiculos.Program+Cliente", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
