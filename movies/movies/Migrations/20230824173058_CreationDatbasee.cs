using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moves_List.Migrations
{
    public partial class CreationDatbasee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Colm1",
                table: "Moves");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Colm1",
                table: "Moves",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
