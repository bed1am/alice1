﻿// <auto-generated />
using Alice1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alice1.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20240326175522_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Alice1.Models.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("developers");
                });

            modelBuilder.Entity("Alice1.Models.ReqRes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Request")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("skillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("skillId");

                    b.ToTable("ReqRess");
                });

            modelBuilder.Entity("Alice1.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("developerId")
                        .HasColumnType("int");

                    b.Property<string>("hook_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("developerId");

                    b.ToTable("skills");
                });

            modelBuilder.Entity("Alice1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("request")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("skillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("skillId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Alice1.Models.ReqRes", b =>
                {
                    b.HasOne("Alice1.Models.Skill", "skill")
                        .WithMany()
                        .HasForeignKey("skillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("skill");
                });

            modelBuilder.Entity("Alice1.Models.Skill", b =>
                {
                    b.HasOne("Alice1.Models.Developer", "developer")
                        .WithMany()
                        .HasForeignKey("developerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("developer");
                });

            modelBuilder.Entity("Alice1.Models.User", b =>
                {
                    b.HasOne("Alice1.Models.Skill", "skill")
                        .WithMany()
                        .HasForeignKey("skillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("skill");
                });
#pragma warning restore 612, 618
        }
    }
}
