using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class campsusercliftp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "cliftp",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "cliftp",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "cliftp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "cliftp",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "cliftp",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "cliftp");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "cliftp");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "cliftp");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "cliftp");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "cliftp");
        }
    }
}
