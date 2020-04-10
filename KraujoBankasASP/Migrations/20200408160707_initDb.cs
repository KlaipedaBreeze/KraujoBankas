﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KraujoBankasASP.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddressLine = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    phones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BloodTypes",
                columns: table => new
                {
                    BloodId = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypes", x => x.BloodId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareInstitutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    AddressFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareInstitutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCareInstitutions_Address_AddressFK",
                        column: x => x.AddressFK,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    DonorId = table.Column<Guid>(nullable: false),
                    WeightInKg = table.Column<int>(nullable: false),
                    HeightInCM = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    AddressFK = table.Column<Guid>(nullable: false),
                    UserFk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.DonorId);
                    table.ForeignKey(
                        name: "FK_Donors_Address_AddressFK",
                        column: x => x.AddressFK,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donors_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlodTests",
                columns: table => new
                {
                    BloodTestId = table.Column<Guid>(nullable: false),
                    IsAbleDonate = table.Column<bool>(nullable: false),
                    Kell = table.Column<bool>(nullable: false),
                    Hemoglobin = table.Column<double>(nullable: false),
                    HBV = table.Column<double>(nullable: false),
                    HCV = table.Column<double>(nullable: false),
                    HIV = table.Column<double>(nullable: false),
                    HTLV = table.Column<double>(nullable: false),
                    ZIKV = table.Column<double>(nullable: false),
                    BoodTypeFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlodTests", x => x.BloodTestId);
                    table.ForeignKey(
                        name: "FK_BlodTests_BloodTypes_BoodTypeFK",
                        column: x => x.BoodTypeFK,
                        principalTable: "BloodTypes",
                        principalColumn: "BloodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    PositionKF = table.Column<Guid>(nullable: false),
                    UserFk = table.Column<string>(nullable: true),
                    InstitutionFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_HealthCareInstitutions_InstitutionFK",
                        column: x => x.InstitutionFK,
                        principalTable: "HealthCareInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionKF",
                        column: x => x.PositionKF,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitId = table.Column<Guid>(nullable: false),
                    DonationDateTime = table.Column<DateTime>(nullable: false),
                    DonorFK = table.Column<Guid>(nullable: false),
                    InstitutionId = table.Column<Guid>(nullable: true),
                    InstitutionFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visits_Donors_DonorFK",
                        column: x => x.DonorFK,
                        principalTable: "Donors",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_HealthCareInstitutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "HealthCareInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receptions",
                columns: table => new
                {
                    ReceptionId = table.Column<Guid>(nullable: false),
                    EmployeeFK = table.Column<Guid>(nullable: false),
                    DonationDate = table.Column<DateTime>(nullable: false),
                    BloodQnt = table.Column<int>(nullable: false),
                    BloodTypeFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptions", x => x.ReceptionId);
                    table.ForeignKey(
                        name: "FK_Receptions_BloodTypes_BloodTypeFK",
                        column: x => x.BloodTypeFK,
                        principalTable: "BloodTypes",
                        principalColumn: "BloodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receptions_Employees_EmployeeFK",
                        column: x => x.EmployeeFK,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationId = table.Column<Guid>(nullable: false),
                    DonationDate = table.Column<DateTime>(nullable: false),
                    DonorFK = table.Column<Guid>(nullable: false),
                    EmployeeFK = table.Column<Guid>(nullable: false),
                    BloodQnt = table.Column<int>(nullable: false),
                    BloodTestFK = table.Column<Guid>(nullable: false),
                    VisitFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationId);
                    table.ForeignKey(
                        name: "FK_Donations_BlodTests_BloodTestFK",
                        column: x => x.BloodTestFK,
                        principalTable: "BlodTests",
                        principalColumn: "BloodTestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_Donors_DonorFK",
                        column: x => x.DonorFK,
                        principalTable: "Donors",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_Employees_EmployeeFK",
                        column: x => x.EmployeeFK,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Donations_Visits_VisitFK",
                        column: x => x.VisitFK,
                        principalTable: "Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d6cae2c4-8d5e-4268-9a68-810dd1131b65", "bf6b4529-7270-4742-843f-6c2c4cb0adc5", "Admin", "ADMIN" },
                    { "91eca320-ca07-4489-906e-91e05262ca59", "f49f67c6-6431-4d1c-8c82-e57e3bcae019", "Institution admin", "INSTITUTION ADMIN" },
                    { "82e73db9-b24b-423d-9fe0-10ca4389e41e", "28f39478-e404-4f4e-a490-7702dbba6bb9", "Donor", "DONOR" },
                    { "06e187ca-9dcf-47ee-856a-5f6dcaa69878", "ef888c85-14b1-47b9-9f1a-d74d1d89924e", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlodTests_BoodTypeFK",
                table: "BlodTests",
                column: "BoodTypeFK");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_BloodTestFK",
                table: "Donations",
                column: "BloodTestFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonorFK",
                table: "Donations",
                column: "DonorFK");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_EmployeeFK",
                table: "Donations",
                column: "EmployeeFK");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_VisitFK",
                table: "Donations",
                column: "VisitFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donors_AddressFK",
                table: "Donors",
                column: "AddressFK");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_UserFk",
                table: "Donors",
                column: "UserFk",
                unique: true,
                filter: "[UserFk] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_InstitutionFK",
                table: "Employees",
                column: "InstitutionFK");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionKF",
                table: "Employees",
                column: "PositionKF");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserFk",
                table: "Employees",
                column: "UserFk",
                unique: true,
                filter: "[UserFk] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareInstitutions_AddressFK",
                table: "HealthCareInstitutions",
                column: "AddressFK");

            migrationBuilder.CreateIndex(
                name: "IX_Receptions_BloodTypeFK",
                table: "Receptions",
                column: "BloodTypeFK");

            migrationBuilder.CreateIndex(
                name: "IX_Receptions_EmployeeFK",
                table: "Receptions",
                column: "EmployeeFK");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DonorFK",
                table: "Visits",
                column: "DonorFK");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_InstitutionId",
                table: "Visits",
                column: "InstitutionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Receptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BlodTests");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "BloodTypes");

            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "HealthCareInstitutions");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}