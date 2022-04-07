﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mobembo.cd_Back_c____;

#nullable disable

namespace Mobembo.cd_Back_c____.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220406142517_ajou_Admin_Client")]
    partial class ajou_Admin_Client
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mobembo.cd_Back_c____.Data_Access.Entity.ContactPersonne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("ContactPersonne", (string)null);

                    b.HasCheckConstraint("CheckMinMail", "LEN(Email)>=6");
                });

            modelBuilder.Entity("Mobembo.cd_Back_c____.Data_Access.Entity.PassWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Mdp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PassWord", (string)null);

                    b.HasCheckConstraint("CheckMinMail", "LEN(Mdp)>=6", c => c.HasName("CheckMinMail1"));
                });

            modelBuilder.Entity("Mobembo.cd_Back_c____.Data_Access.Entity.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Ddn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RolePersonneId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_personne");

                    b.HasIndex("RolePersonneId");

                    b.ToTable("Personne", (string)null);

                    b.HasCheckConstraint("CheckAdult", "DateDiff(year, Ddn, GetDate())>=18");

                    b.HasCheckConstraint("CheckMinNom", "LEN(Prenom)>=3");
                });

            modelBuilder.Entity("Mobembo.cd_Back_c____.Data_Access.Entity.RolePersonne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomRole")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Client");

                    b.HasKey("Id");

                    b.ToTable("RolePersonne", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NomRole = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            NomRole = "Client"
                        });
                });

            modelBuilder.Entity("Mobembo.cd_Back_c____.Data_Access.Entity.Personne", b =>
                {
                    b.HasOne("Mobembo.cd_Back_c____.Data_Access.Entity.ContactPersonne", "Contact")
                        .WithOne("AppartientA")
                        .HasForeignKey("Mobembo.cd_Back_c____.Data_Access.Entity.Personne", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Contact_Personne");

                    b.HasOne("Mobembo.cd_Back_c____.Data_Access.Entity.PassWord", "mdp")
                        .WithOne("AppartientA")
                        .HasForeignKey("Mobembo.cd_Back_c____.Data_Access.Entity.Personne", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobembo.cd_Back_c____.Data_Access.Entity.RolePersonne", "RolePersonne")
                        .WithMany("Personnes")
                        .HasForeignKey("RolePersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("RolePersonne");

                    b.Navigation("mdp");
                });

            modelBuilder.Entity("Mobembo.cd_Back_c____.Data_Access.Entity.ContactPersonne", b =>
                {
                    b.Navigation("AppartientA")
                        .IsRequired();
                });

            modelBuilder.Entity("Mobembo.cd_Back_c____.Data_Access.Entity.PassWord", b =>
                {
                    b.Navigation("AppartientA")
                        .IsRequired();
                });

            modelBuilder.Entity("Mobembo.cd_Back_c____.Data_Access.Entity.RolePersonne", b =>
                {
                    b.Navigation("Personnes");
                });
#pragma warning restore 612, 618
        }
    }
}
