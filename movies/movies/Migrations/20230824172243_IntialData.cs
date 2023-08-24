using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moves_List.Migrations
{
    public partial class IntialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Genres_GenreId",
                table: "Moves");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Poster",
                table: "Moves",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddColumn<byte[]>(
                name: "Colm1",
                table: "Moves",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Genres_GenreId",
                table: "Moves",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Genres_GenreId",
                table: "Moves");

            migrationBuilder.DropColumn(
                name: "Colm1",
                table: "Moves");

            migrationBuilder.AlterColumn<byte>(
                name: "Poster",
                table: "Moves",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Genres_GenreId",
                table: "Moves",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
