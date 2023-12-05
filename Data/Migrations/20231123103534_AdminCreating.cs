using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AdminCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyId", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "Facebook", "FatherName", "FirstName", "FullName", "GenderId", "Github", "Image", "Instagram", "LastName", "LastSeenDate", "Linkedin", "LockoutEnabled", "LockoutEnd", "MiddleName", "MotherName", "NID", "NIDVerifiedBy", "NIDVerifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SpouseName", "Twitter", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("165d85b8-c45b-4fdf-b812-eb27e9e67264"), 0, null, "c0546a67-12e3-413e-98d7-2e981f03aa95", new DateTime(1993, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mail.com", false, null, "N/A", "System", "Admin", 1, null, null, null, "", null, null, false, null, "Admin", "N/A", "", null, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEFTw0YzFmNSap0Oq8Tb4C2h1Jdvd1fMHL+pKDwaxcY+2Rg/i3jP0cAKJshnm6wy/fQ==", "01723962962", false, "KOFABGFNZCSAIOQ7VCPER53GEIMMBIFK", "N/A", null, false, "admin@mail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("165d85b8-c45b-4fdf-b812-eb27e9e67264"));
        }
    }
}
