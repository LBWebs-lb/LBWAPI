using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class campsuserprediscli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "prediscli",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "prediscli",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "prediscli",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "prediscli",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "prediscli",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "prediscli");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "prediscli");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "prediscli");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "prediscli");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "prediscli");
        }
    }
}
