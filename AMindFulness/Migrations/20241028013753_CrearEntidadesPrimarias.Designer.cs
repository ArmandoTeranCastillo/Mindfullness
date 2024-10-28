﻿// <auto-generated />
using System;
using AMindFulness.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AMindFulness.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241028013753_CrearEntidadesPrimarias")]
    partial class CrearEntidadesPrimarias
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AMindFulness.MVVM.Models.DistorsionCognitiva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Distorsiones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Filtraje"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Polarización"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sobregeneralización"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Desestimar lo Positivo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Catastrofismo"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Personalización"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Falacia de Control"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Falacia de la Justicia"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Falacia del Cambio"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Culpa"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Deberías"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Razonamiento Emocional"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Etiquetado Global"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Siempre tener la razón"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Precipitar Conclusiones"
                        });
                });

            modelBuilder.Entity("AMindFulness.MVVM.Models.Etiqueta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("AMindFulness.MVVM.Models.Pensamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("varchar(800)");

                    b.Property<string>("Distorsiones")
                        .HasColumnType("longtext");

                    b.Property<string>("Etiquetas")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaReformacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Reformacion")
                        .HasMaxLength(800)
                        .HasColumnType("varchar(800)");

                    b.HasKey("Id");

                    b.ToTable("Pensamientos");
                });

            modelBuilder.Entity("DistorsionCognitivaPensamiento", b =>
                {
                    b.Property<int>("DistorsionesCognitivasId")
                        .HasColumnType("int");

                    b.Property<int>("PensamientosId")
                        .HasColumnType("int");

                    b.HasKey("DistorsionesCognitivasId", "PensamientosId");

                    b.HasIndex("PensamientosId");

                    b.ToTable("DistorsionCognitivaPensamiento");
                });

            modelBuilder.Entity("EtiquetaPensamiento", b =>
                {
                    b.Property<int>("EtiquetasPensamientoId")
                        .HasColumnType("int");

                    b.Property<int>("PensamientosId")
                        .HasColumnType("int");

                    b.HasKey("EtiquetasPensamientoId", "PensamientosId");

                    b.HasIndex("PensamientosId");

                    b.ToTable("EtiquetaPensamiento");
                });

            modelBuilder.Entity("DistorsionCognitivaPensamiento", b =>
                {
                    b.HasOne("AMindFulness.MVVM.Models.DistorsionCognitiva", null)
                        .WithMany()
                        .HasForeignKey("DistorsionesCognitivasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMindFulness.MVVM.Models.Pensamiento", null)
                        .WithMany()
                        .HasForeignKey("PensamientosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EtiquetaPensamiento", b =>
                {
                    b.HasOne("AMindFulness.MVVM.Models.Etiqueta", null)
                        .WithMany()
                        .HasForeignKey("EtiquetasPensamientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMindFulness.MVVM.Models.Pensamiento", null)
                        .WithMany()
                        .HasForeignKey("PensamientosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
