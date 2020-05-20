using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class forenkeyclidev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_clidev_icli",
                table: "clidev",
                column: "icli");

            migrationBuilder.AddForeignKey(
                name: "FK_clidev_clilb_icli",
                table: "clidev",
                column: "icli",
                principalTable: "clilb",
                principalColumn: "icli",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clidev_clilb_icli",
                table: "clidev");

            migrationBuilder.DropIndex(
                name: "IX_clidev_icli",
                table: "clidev");
        }
    }
}
