using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_refactoring.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Animals",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Sick",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Animals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_UserId",
                table: "Animals",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_UserId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Sick",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Animals",
                newName: "id");
        }
    }
}
