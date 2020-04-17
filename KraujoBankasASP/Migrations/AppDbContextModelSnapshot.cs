﻿// <auto-generated />
using System;
using KraujoBankasASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KraujoBankasASP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("HeightInCM")
                        .HasColumnType("int");

                    b.Property<string>("UserFk")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("WeightOver50")
                        .HasColumnType("bit");

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

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

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
                            Id = "8f9bb096-5cdf-4662-841f-6ac48176a568",
                            ConcurrencyStamp = "aea22bf8-408e-4437-b82e-736e4e957556",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2ceaaf69-0d7c-4d9f-af63-c1c1cf16d5e5",
                            ConcurrencyStamp = "cdc11597-6545-4d78-b3aa-145875e0986c",
                            Name = "Institution admin",
                            NormalizedName = "INSTITUTION ADMIN"
                        },
                        new
                        {
                            Id = "813509db-6a5e-4518-918c-c4471cc0294d",
                            ConcurrencyStamp = "f692de80-e2f8-4868-acf5-ffd995eb9f7d",
                            Name = "Donor",
                            NormalizedName = "DONOR"
                        },
                        new
                        {
                            Id = "28f7e677-a22a-4e0b-814d-515c55f7a081",
                            ConcurrencyStamp = "78fe9696-fbdf-4538-9db4-92839ab512a4",
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
