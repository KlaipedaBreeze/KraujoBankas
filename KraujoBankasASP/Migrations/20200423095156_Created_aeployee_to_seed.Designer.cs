﻿// <auto-generated />
using System;
using KraujoBankasASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KraujoBankasASP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200423095156_Created_aeployee_to_seed")]
    partial class Created_aeployee_to_seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KraujoBankasASP.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressLine")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.BloodTest", b =>
                {
                    b.Property<Guid>("BloodTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BoodTypeFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("HBV")
                        .HasColumnType("float");

                    b.Property<double>("HCV")
                        .HasColumnType("float");

                    b.Property<double>("HIV")
                        .HasColumnType("float");

                    b.Property<double>("HTLV")
                        .HasColumnType("float");

                    b.Property<double>("Hemoglobin")
                        .HasColumnType("float");

                    b.Property<bool>("IsAbleDonate")
                        .HasColumnType("bit");

                    b.Property<bool>("Kell")
                        .HasColumnType("bit");

                    b.Property<double>("ZIKV")
                        .HasColumnType("float");

                    b.HasKey("BloodTestId");

                    b.HasIndex("BoodTypeFK");

                    b.ToTable("BlodTests");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.BloodType", b =>
                {
                    b.Property<Guid>("BloodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BloodId");

                    b.ToTable("BloodTypes");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Donation", b =>
                {
                    b.Property<Guid>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BloodQnt")
                        .HasColumnType("int");

                    b.Property<Guid>("BloodTestFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DonationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DonorFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VisitFK")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DonationId");

                    b.HasIndex("BloodTestFK")
                        .IsUnique();

                    b.HasIndex("DonorFK");

                    b.HasIndex("EmployeeFK");

                    b.HasIndex("VisitFK")
                        .IsUnique();

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Donor", b =>
                {
                    b.Property<Guid>("DonorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HeightInCM")
                        .HasColumnType("int");

                    b.Property<string>("UserFk")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("DonorId");

                    b.HasIndex("AddressFK");

                    b.HasIndex("UserFk")
                        .IsUnique()
                        .HasFilter("[UserFk] IS NOT NULL");

                    b.ToTable("Donors");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InstitutionFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PositionFk")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserFk")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("InstitutionFK");

                    b.HasIndex("PositionFk");

                    b.HasIndex("UserFk")
                        .IsUnique()
                        .HasFilter("[UserFk] IS NOT NULL");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.HealthCareInstitution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressFK");

                    b.ToTable("HealthCareInstitutions");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Position", b =>
                {
                    b.Property<Guid>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Reception", b =>
                {
                    b.Property<Guid>("ReceptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BloodQnt")
                        .HasColumnType("int");

                    b.Property<Guid>("BloodTypeFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DonationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeFK")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReceptionId");

                    b.HasIndex("BloodTypeFK");

                    b.HasIndex("EmployeeFK");

                    b.ToTable("Receptions");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalIDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("RegComplete")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Visit", b =>
                {
                    b.Property<Guid>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DonationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DonorFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InstitutionFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("InstitutionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VisitId");

                    b.HasIndex("DonorFK");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ece133e8-0786-48c0-ae54-feecf54cb36d",
                            ConcurrencyStamp = "9f6e9d86-48bd-4ccc-9661-9400172d7aa1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "49f8be9f-0d7a-495a-8298-d5657fdd95dc",
                            ConcurrencyStamp = "44f3b174-46e6-4b2a-b8ac-a7d3ce89e9ce",
                            Name = "Institution admin",
                            NormalizedName = "INSTITUTION ADMIN"
                        },
                        new
                        {
                            Id = "93a25a44-26dc-46ac-a80d-af2f3b2fd898",
                            ConcurrencyStamp = "addd271a-3db2-4ca1-98c3-f78962bbbffc",
                            Name = "Donor",
                            NormalizedName = "DONOR"
                        },
                        new
                        {
                            Id = "0efe163c-7cd2-4c22-a3bf-2c7e7b865290",
                            ConcurrencyStamp = "889fd188-27e1-480d-bca3-1ebb5010bc66",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.BloodTest", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.BloodType", "BloodType")
                        .WithMany("BloodTests")
                        .HasForeignKey("BoodTypeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Donation", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.BloodTest", "BloodTest")
                        .WithOne("Donation")
                        .HasForeignKey("KraujoBankasASP.Models.Donation", "BloodTestFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.Donor", "Donor")
                        .WithMany("Donations")
                        .HasForeignKey("DonorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.Employee", "Employee")
                        .WithMany("Donations")
                        .HasForeignKey("EmployeeFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.Visit", "Visit")
                        .WithOne("Donation")
                        .HasForeignKey("KraujoBankasASP.Models.Donation", "VisitFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Donor", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.Address", "Address")
                        .WithMany("Donors")
                        .HasForeignKey("AddressFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.User", "User")
                        .WithOne("Donor")
                        .HasForeignKey("KraujoBankasASP.Models.Donor", "UserFk");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Employee", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.HealthCareInstitution", "Institution")
                        .WithMany("Employees")
                        .HasForeignKey("InstitutionFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("KraujoBankasASP.Models.Employee", "UserFk");
                });

            modelBuilder.Entity("KraujoBankasASP.Models.HealthCareInstitution", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.Address", "Address")
                        .WithMany("Institutions")
                        .HasForeignKey("AddressFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Reception", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.BloodType", "BloodType")
                        .WithMany("Receptions")
                        .HasForeignKey("BloodTypeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.Employee", "Employee")
                        .WithMany("Receptions")
                        .HasForeignKey("EmployeeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KraujoBankasASP.Models.Visit", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.Donor", "Donor")
                        .WithMany("Visits")
                        .HasForeignKey("DonorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.HealthCareInstitution", "Institution")
                        .WithMany("Visits")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KraujoBankasASP.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("KraujoBankasASP.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}