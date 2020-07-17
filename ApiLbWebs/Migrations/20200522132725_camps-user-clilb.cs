using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class campsuserclilb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "clilb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "clilb",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "clilb",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "clilb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "clilb",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "clilb");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "clilb");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "clilb");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "clilb");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "clilb");
        }
    }
}
