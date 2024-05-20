﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaEnlace.API.Data;

#nullable disable

namespace SistemaEnlace.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240520021615_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.Conversacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdJoven")
                        .HasColumnType("int");

                    b.Property<int>("IdTutor")
                        .HasColumnType("int");

                    b.Property<int>("jovenVulnerablesid")
                        .HasColumnType("int");

                    b.Property<int>("tutorsid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("jovenVulnerablesid");

                    b.HasIndex("tutorsid");

                    b.ToTable("conversacions");
                });

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.Formulario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSupervisor")
                        .HasColumnType("int");

                    b.Property<int>("Idconversacion")
                        .HasColumnType("int");

                    b.Property<int>("Idfundacion")
                        .HasColumnType("int");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("supervisorsid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("supervisorsid");

                    b.ToTable("formularios");
                });

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.Fundacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("fundacions");
                });

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.JovenVulnerable", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Situacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("JovenesVulnerables");
                });

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.Supervisor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("supervisors");
                });

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.Tutor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("Experiencia")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.Conversacion", b =>
                {
                    b.HasOne("SistemaEnlace.Shared.Entities.JovenVulnerable", "jovenVulnerables")
                        .WithMany("conversacions")
                        .HasForeignKey("jovenVulnerablesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaEnlace.Shared.Entities.Tutor", "tutors")
                        .WithMany()
                        .HasForeignKey("tutorsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("jovenVulnerables");

                    b.Navigation("tutors");
                });

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.Formulario", b =>
                {
                    b.HasOne("SistemaEnlace.Shared.Entities.Supervisor", "supervisors")
                        .WithMany()
                        .HasForeignKey("supervisorsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("supervisors");
                });

            modelBuilder.Entity("SistemaEnlace.Shared.Entities.JovenVulnerable", b =>
                {
                    b.Navigation("conversacions");
                });
#pragma warning restore 612, 618
        }
    }
}