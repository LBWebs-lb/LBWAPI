using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class usermaillbwebs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LBAcces",
                columns: table => new
                {
                    idlb = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userWp = table.Column<string>(nullable: true),
                    passWd = table.Column<string>(nullable: true),
                    linkWp = table.Column<string>(nullable: true),
                    acc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LBAcces", x => x.idlb);
                });

            migrationBuilder.CreateTable(
                name: "LBMail",
                columns: table => new
                {
                    idlbmail = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dnommail = table.Column<string>(nullable: true),
                    mailuser = table.Column<string>(nullable: true),
                    passmail = table.Column<string>(nullable: true),
                    lnkmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LBMail", x => x.idlbmail);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LBAcces");

            migrationBuilder.DropTable(
                name: "LBMail");
        }
    }
}
