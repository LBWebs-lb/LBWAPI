using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class campsuserclidev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "clidev",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "clidev",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "clidev",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "clidev",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "clidev",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "clidev");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "clidev");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "clidev");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "clidev");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "clidev");
        }
    }
}
