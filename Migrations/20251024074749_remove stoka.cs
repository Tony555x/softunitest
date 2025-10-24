using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_refactoring.Migrations
{
    /// <inheritdoc />
    public partial class removestoka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Stoki");

            migrationBuilder.RenameColumn(
                name: "purvoime",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "purvoime");

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stoki",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cena = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Price in unknown currency"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Product name"),
                    Opisanie = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Product description"),
                    Qty = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Broq koito imame za produkta")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoki", x => x.Id);
                });
        }
    }
}
