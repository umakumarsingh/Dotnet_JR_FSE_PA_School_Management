using Microsoft.EntityFrameworkCore.Migrations;

namespace Schoolmanagement.DataLayer.Migrations
{
    public partial class BookIdUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "BookBorrows");

            migrationBuilder.RenameColumn(
                name: "ClassList",
                table: "Students",
                newName: "classList");

            migrationBuilder.AlterColumn<int>(
                name: "classList",
                table: "Students",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BookBorrows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrows_BookId",
                table: "BookBorrows",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookBorrows_Libraries_BookId",
                table: "BookBorrows",
                column: "BookId",
                principalTable: "Libraries",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBorrows_Libraries_BookId",
                table: "BookBorrows");

            migrationBuilder.DropIndex(
                name: "IX_BookBorrows_BookId",
                table: "BookBorrows");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookBorrows");

            migrationBuilder.RenameColumn(
                name: "classList",
                table: "Students",
                newName: "ClassList");

            migrationBuilder.AlterColumn<int>(
                name: "ClassList",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "BookBorrows",
                nullable: false,
                defaultValue: false);
        }
    }
}
