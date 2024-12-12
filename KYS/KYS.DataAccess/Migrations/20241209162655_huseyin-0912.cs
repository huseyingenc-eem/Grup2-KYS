using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KYS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class huseyin0912 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublicherID",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Books",
                newName: "PublisherID");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                newName: "IX_Books_PublisherID");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublisherID",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherID",
                table: "Books",
                column: "PublisherID",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherID",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "PublisherID",
                table: "Books",
                newName: "PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PublisherID",
                table: "Books",
                newName: "IX_Books_PublisherId");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublisherId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "PublicherID",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id");
        }
    }
}
