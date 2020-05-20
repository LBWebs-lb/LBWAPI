using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class columnasusermail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "LBMail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "LBMail",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "LBMail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "LBMail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "LBMail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "LBMail");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "LBMail");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "LBMail");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "LBMail");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "LBMail");
        }
    }
}
