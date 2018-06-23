using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Database.MSSQL.Migrations
{
    public partial class initialscripts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicLivings",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    IdCardNumber = table.Column<string>(maxLength: 30, nullable: true),
                    GainDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicLivings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    IdCardNumber = table.Column<string>(maxLength: 30, nullable: true),
                    CarBrand = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Communists",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    IdCardNumber = table.Column<string>(maxLength: 30, nullable: true),
                    PartyStanding = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GovernmentStaffs",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    IdCardNumber = table.Column<string>(maxLength: 30, nullable: true),
                    Position = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GovernmentStaffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    IdCardNumber = table.Column<string>(maxLength: 30, nullable: true),
                    BornPlace = table.Column<string>(maxLength: 100, nullable: true),
                    LivingPlace = table.Column<string>(maxLength: 100, nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.Sql(@"

            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicLivings");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Communists");

            migrationBuilder.DropTable(
                name: "GovernmentStaffs");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
