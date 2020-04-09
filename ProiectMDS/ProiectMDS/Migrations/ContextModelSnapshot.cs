﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectMDS.Contexts_Fitness;

namespace ProiectMDS.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProiectMDS.Model_Fitness.Abonament", b =>
                {
                    b.Property<int>("abonamentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("pret");

                    b.Property<string>("tip");

                    b.HasKey("abonamentId");

                    b.ToTable("Abonamente");
                });

            modelBuilder.Entity("ProiectMDS.Model_Fitness.Angajat", b =>
                {
                    b.Property<int>("angajatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("abonamentId");

                    b.Property<string>("numarTelefon");

                    b.Property<string>("nume");

                    b.Property<string>("prenume");

                    b.Property<double>("salariu");

                    b.HasKey("angajatId");

                    b.HasIndex("abonamentId");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("ProiectMDS.Model_Fitness.Client", b =>
                {
                    b.Property<int>("clientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("numarTelefon");

                    b.Property<string>("nume");

                    b.Property<string>("prenume");

                    b.HasKey("clientId");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("ProiectMDS.Model_Fitness.ClientAbonament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("abonamentId");

                    b.Property<int>("clientId");

                    b.HasKey("Id");

                    b.HasIndex("abonamentId");

                    b.HasIndex("clientId");

                    b.ToTable("ClientAbonamente");
                });

            modelBuilder.Entity("ProiectMDS.Model_Fitness.ClientSupliment", b =>
                {
                    b.Property<int>("clientSuplimentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("clientId");

                    b.Property<int>("suplimentId");

                    b.HasKey("clientSuplimentId");

                    b.HasIndex("clientId");

                    b.HasIndex("suplimentId");

                    b.ToTable("ClientSuplimente");
                });

            modelBuilder.Entity("ProiectMDS.Model_Fitness.Supliment", b =>
                {
                    b.Property<int>("suplimentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("denumire");

                    b.Property<double>("pret");

                    b.Property<string>("tip");

                    b.HasKey("suplimentId");

                    b.ToTable("Suplimente");
                });

            modelBuilder.Entity("ProiectMDS.Model_Fitness.Angajat", b =>
                {
                    b.HasOne("ProiectMDS.Model_Fitness.Abonament", "Abonament")
                        .WithMany("Angajat")
                        .HasForeignKey("abonamentId");
                });

            modelBuilder.Entity("ProiectMDS.Model_Fitness.ClientAbonament", b =>
                {
                    b.HasOne("ProiectMDS.Model_Fitness.Abonament", "Abonament")
                        .WithMany("ClientAbonament")
                        .HasForeignKey("abonamentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProiectMDS.Model_Fitness.Client", "Client")
                        .WithMany("ClientAbonament")
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProiectMDS.Model_Fitness.ClientSupliment", b =>
                {
                    b.HasOne("ProiectMDS.Model_Fitness.Client", "Client")
                        .WithMany("ClientSupliment")
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProiectMDS.Model_Fitness.Supliment", "Supliment")
                        .WithMany("ClientSupliment")
                        .HasForeignKey("suplimentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}