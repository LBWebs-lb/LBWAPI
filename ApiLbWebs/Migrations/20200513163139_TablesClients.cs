using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class TablesClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clidev",
                columns: table => new
                {
                    idev = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icli = table.Column<int>(nullable: false),
                    wdpins = table.Column<bool>(nullable: false),
                    userwd = table.Column<string>(nullable: true),
                    passwd = table.Column<string>(nullable: true),
                    linkdev = table.Column<string>(nullable: true),
                    acc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clidev", x => x.idev);
                });

            migrationBuilder.CreateTable(
                name: "cliftp",
                columns: table => new
                {
                    iftp = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userftp = table.Column<string>(nullable: true),
                    passftp = table.Column<string>(nullable: true),
                    ipserver = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliftp", x => x.iftp);
                });

            migrationBuilder.CreateTable(
                name: "clihos",
                columns: table => new
                {
                    ihos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userhos = table.Column<string>(nullable: true),
                    passhos = table.Column<string>(nullable: true),
                    linkwphos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clihos", x => x.ihos);
                });

            migrationBuilder.CreateTable(
                name: "clilb",
                columns: table => new
                {
                    icli = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ihos = table.Column<int>(nullable: false),
                    iftp = table.Column<int>(nullable: false),
                    ipredis = table.Column<int>(nullable: false),
                    dnom = table.Column<string>(nullable: true),
                    dnommail = table.Column<string>(nullable: true),
                    est = table.Column<int>(nullable: false),
                    dobs = table.Column<string>(nullable: true),
                    tcli = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clilb", x => x.icli);
                });

            migrationBuilder.CreateTable(
                name: "prediscli",
                columns: table => new
                {
                    ipredis = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ptheme = table.Column<string>(nullable: true),
                    envcli = table.Column<bool>(nullable: false),
                    themebuy = table.Column<bool>(nullable: false),
                    pctheme = table.Column<int>(nullable: false),
                    bouby = table.Column<string>(nullable: true),
                    paid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prediscli", x => x.ipredis);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clidev");

            migrationBuilder.DropTable(
                name: "cliftp");

            migrationBuilder.DropTable(
                name: "clihos");

            migrationBuilder.DropTable(
                name: "clilb");

            migrationBuilder.DropTable(
                name: "prediscli");
        }
    }
}
