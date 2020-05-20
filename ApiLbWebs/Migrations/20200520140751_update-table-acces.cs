using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class updatetableacces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "LBAcces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "LBAcces",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "LBAcces",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "LBAcces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "LBAcces",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "LBAcces");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "LBAcces");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "LBAcces");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "LBAcces");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "LBAcces");
        }
    }
}
