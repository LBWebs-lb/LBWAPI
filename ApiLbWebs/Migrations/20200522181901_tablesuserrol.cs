using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class tablesuserrol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usermod",
                columns: table => new
                {
                    imod = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dnommod = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usermod", x => x.imod);
                });

            migrationBuilder.CreateTable(
                name: "userrol",
                columns: table => new
                {
                    irol = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dnomrol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userrol", x => x.irol);
                });

            migrationBuilder.CreateTable(
                name: "userop",
                columns: table => new
                {
                    iuserop = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dnommod = table.Column<string>(nullable: true),
                    iMod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userop", x => x.iuserop);
                    table.ForeignKey(
                        name: "FK_userop_usermod_iMod",
                        column: x => x.iMod,
                        principalTable: "usermod",
                        principalColumn: "imod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userslb",
                columns: table => new
                {
                    iduser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    cyuscusualt = table.Column<DateTime>(nullable: false),
                    irol = table.Column<int>(nullable: true),
                    Rolirol = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userslb", x => x.iduser);
                    table.ForeignKey(
                        name: "FK_userslb_userrol_Rolirol",
                        column: x => x.Rolirol,
                        principalTable: "userrol",
                        principalColumn: "irol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usrrolop",
                columns: table => new
                {
                    iusrrolop = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    irol = table.Column<int>(nullable: false),
                    iuserop = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usrrolop", x => x.iusrrolop);
                    table.ForeignKey(
                        name: "FK_usrrolop_userrol_irol",
                        column: x => x.irol,
                        principalTable: "userrol",
                        principalColumn: "irol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usrrolop_userop_iuserop",
                        column: x => x.iuserop,
                        principalTable: "userop",
                        principalColumn: "iuserop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userop_iMod",
                table: "userop",
                column: "iMod");

            migrationBuilder.CreateIndex(
                name: "IX_userslb_Rolirol",
                table: "userslb",
                column: "Rolirol");

            migrationBuilder.CreateIndex(
                name: "IX_usrrolop_irol",
                table: "usrrolop",
                column: "irol");

            migrationBuilder.CreateIndex(
                name: "IX_usrrolop_iuserop",
                table: "usrrolop",
                column: "iuserop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userslb");

            migrationBuilder.DropTable(
                name: "usrrolop");

            migrationBuilder.DropTable(
                name: "userrol");

            migrationBuilder.DropTable(
                name: "userop");

            migrationBuilder.DropTable(
                name: "usermod");
        }
    }
}
