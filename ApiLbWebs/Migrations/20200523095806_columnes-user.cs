using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class columnesuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "usrrolop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "usrrolop",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "usrrolop",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "usrrolop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "usrrolop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "userslb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "userslb",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "userslb",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "userslb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "userslb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "userrol",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "userrol",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "userrol",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "userrol",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "userrol",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "userop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "userop",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "userop",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "userop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "userop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusualt",
                table: "usermod",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cusumod",
                table: "usermod",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "faltrto",
                table: "usermod",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "fmod",
                table: "usermod",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hmod",
                table: "usermod",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "usrrolop");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "usrrolop");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "usrrolop");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "usrrolop");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "usrrolop");

            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "userslb");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "userslb");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "userslb");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "userslb");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "userslb");

            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "userrol");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "userrol");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "userrol");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "userrol");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "userrol");

            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "userop");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "userop");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "userop");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "userop");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "userop");

            migrationBuilder.DropColumn(
                name: "cusualt",
                table: "usermod");

            migrationBuilder.DropColumn(
                name: "cusumod",
                table: "usermod");

            migrationBuilder.DropColumn(
                name: "faltrto",
                table: "usermod");

            migrationBuilder.DropColumn(
                name: "fmod",
                table: "usermod");

            migrationBuilder.DropColumn(
                name: "hmod",
                table: "usermod");
        }
    }
}
