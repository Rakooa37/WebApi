﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240209141608_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebAPI.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WebAPI.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("WebAPI.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.Property<int>("SmartPhoneId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("SmartPhoneId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WebAPI.Models.Reviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviewers");
                });

            modelBuilder.Entity("WebAPI.Models.SmartPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SmartPhones");
                });

            modelBuilder.Entity("WebAPI.Models.SmartPhoneCategory", b =>
                {
                    b.Property<int>("SmartPhoneId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("SmartPhoneId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SmartPhoneCategories");
                });

            modelBuilder.Entity("WebAPI.Models.SmartPhoneOwner", b =>
                {
                    b.Property<int>("SmartPhoneId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("SmartPhoneId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("SmartPhoneOwners");
                });

            modelBuilder.Entity("WebAPI.Models.Owner", b =>
                {
                    b.HasOne("WebAPI.Models.Country", "Country")
                        .WithMany("Owners")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("WebAPI.Models.Review", b =>
                {
                    b.HasOne("WebAPI.Models.Reviewer", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.SmartPhone", "SmartPhone")
                        .WithMany("Reviews")
                        .HasForeignKey("SmartPhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reviewer");

                    b.Navigation("SmartPhone");
                });

            modelBuilder.Entity("WebAPI.Models.SmartPhoneCategory", b =>
                {
                    b.HasOne("WebAPI.Models.Category", "Category")
                        .WithMany("SmartPhoneCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.SmartPhone", "SmartPhone")
                        .WithMany("SmartPhoneCategories")
                        .HasForeignKey("SmartPhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("SmartPhone");
                });

            modelBuilder.Entity("WebAPI.Models.SmartPhoneOwner", b =>
                {
                    b.HasOne("WebAPI.Models.Owner", "Owner")
                        .WithMany("SmartPhoneOwners")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.SmartPhone", "SmartPhone")
                        .WithMany("SmartPhoneOwners")
                        .HasForeignKey("SmartPhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("SmartPhone");
                });

            modelBuilder.Entity("WebAPI.Models.Category", b =>
                {
                    b.Navigation("SmartPhoneCategories");
                });

            modelBuilder.Entity("WebAPI.Models.Country", b =>
                {
                    b.Navigation("Owners");
                });

            modelBuilder.Entity("WebAPI.Models.Owner", b =>
                {
                    b.Navigation("SmartPhoneOwners");
                });

            modelBuilder.Entity("WebAPI.Models.Reviewer", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("WebAPI.Models.SmartPhone", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("SmartPhoneCategories");

                    b.Navigation("SmartPhoneOwners");
                });
#pragma warning restore 612, 618
        }
    }
}
