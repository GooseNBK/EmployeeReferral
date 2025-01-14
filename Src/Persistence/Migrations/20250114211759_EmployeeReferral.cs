using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeReferral : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeReferral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ApplicantFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    ApplicantLastName = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    ReferredPositionNameAndTitle = table.Column<string>(type: "TEXT", nullable: true),
                    ReferrerFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    ReferrerLastName = table.Column<string>(type: "TEXT", nullable: true),
                    ReferrerTitle = table.Column<string>(type: "TEXT", nullable: true),
                    ReferrerDepartment = table.Column<string>(type: "TEXT", nullable: true),
                    ReferrerEmail = table.Column<string>(type: "TEXT", nullable: true),
                    ReferrerPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AddressLine1 = table.Column<string>(type: "TEXT", nullable: true),
                    AddressLine2 = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Region = table.Column<string>(type: "TEXT", nullable: true),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    SignatureUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeReferral", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeReferral");
        }
    }
}
