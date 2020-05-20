using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLbWebs.Migrations
{
    public partial class forenkeynullkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "ipredis",
                table: "clilb",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ihos",
                table: "clilb",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "iftp",
                table: "clilb",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_clilb_cliftp_iftp",
                table: "clilb",
                column: "iftp",
                principalTable: "cliftp",
                principalColumn: "iftp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_clilb_clihos_ihos",
                table: "clilb",
                column: "ihos",
                principalTable: "clihos",
                principalColumn: "ihos",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_clilb_prediscli_ipredis",
                table: "clilb",
                column: "ipredis",
                principalTable: "prediscli",
                principalColumn: "ipredis",
                onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.AlterColumn<int>(
                name: "ipredis",
                table: "clilb",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ihos",
                table: "clilb",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "iftp",
                table: "clilb",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
