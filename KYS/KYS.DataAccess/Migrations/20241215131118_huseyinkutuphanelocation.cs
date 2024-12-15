using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KYS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class huseyinkutuphanelocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Books",
                newName: "ShelfLocation");

            migrationBuilder.AddColumn<string>(
                name: "ShortCode",
                table: "BookTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortCode",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortCode",
                table: "BookTypes");

            migrationBuilder.DropColumn(
                name: "ShortCode",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "ShelfLocation",
                table: "Books",
                newName: "ISBN");
        }
    }
}
