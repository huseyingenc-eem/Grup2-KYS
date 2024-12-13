using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KYS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class huseyinSonHali : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "BorrowRecords");

            migrationBuilder.AddColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowRecords",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorrowDate",
                table: "BorrowRecords");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "BorrowRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
