using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMediacion.Migrations
{
    public partial class GuitarAdjustments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guitars",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuitarId",
                table: "GuitarLog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GuitarLog_GuitarId",
                table: "GuitarLog",
                column: "GuitarId");

            migrationBuilder.AddForeignKey(
                name: "FK_GuitarLog_Guitars_GuitarId",
                table: "GuitarLog",
                column: "GuitarId",
                principalTable: "Guitars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuitarLog_Guitars_GuitarId",
                table: "GuitarLog");

            migrationBuilder.DropIndex(
                name: "IX_GuitarLog_GuitarId",
                table: "GuitarLog");

            migrationBuilder.DropColumn(
                name: "GuitarId",
                table: "GuitarLog");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guitars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
