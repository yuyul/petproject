using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace petproject.Migrations
{
    public partial class CardPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Cards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Cards");
        }
    }
}
