using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class campsuserclihos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "clihos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "clihos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "clihos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "clihos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "clihos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "clihos");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "clihos");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "clihos");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "clihos");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "clihos");
        }
    }
}
