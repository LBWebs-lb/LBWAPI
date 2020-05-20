using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class forenkeyall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_clilb_iftp",
                table: "clilb",
                column: "iftp");

            migrationBuilder.CreateIndex(
                name: "IX_clilb_ihos",
                table: "clilb",
                column: "ihos");

            migrationBuilder.CreateIndex(
                name: "IX_clilb_ipredis",
                table: "clilb",
                column: "ipredis");

            migrationBuilder.AddForeignKey(
                name: "FK_clilb_cliftp_iftp",
                table: "clilb",
                column: "iftp",
                principalTable: "cliftp",
                principalColumn: "iftp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clilb_clihos_ihos",
                table: "clilb",
                column: "ihos",
                principalTable: "clihos",
                principalColumn: "ihos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clilb_prediscli_ipredis",
                table: "clilb",
                column: "ipredis",
                principalTable: "prediscli",
                principalColumn: "ipredis",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clilb_cliftp_iftp",
                table: "clilb");

            migrationBuilder.DropForeignKey(
                name: "FK_clilb_clihos_ihos",
                table: "clilb");

            migrationBuilder.DropForeignKey(
                name: "FK_clilb_prediscli_ipredis",
                table: "clilb");

            migrationBuilder.DropIndex(
                name: "IX_clilb_iftp",
                table: "clilb");

            migrationBuilder.DropIndex(
                name: "IX_clilb_ihos",
                table: "clilb");

            migrationBuilder.DropIndex(
                name: "IX_clilb_ipredis",
                table: "clilb");
        }
    }
}
