using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bands.DAL.Migrations
{
    public partial class practice_table_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoolleMapsAddress",
                table: "PracticeLocations");

            migrationBuilder.AddColumn<decimal>(
                name: "Latitude",
                table: "PracticeLocations",
                type: "numeric(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Longitude",
                table: "PracticeLocations",
                type: "numeric(18,6)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "PracticeLocations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "PracticeLocations");

            migrationBuilder.AddColumn<string>(
                name: "GoolleMapsAddress",
                table: "PracticeLocations",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }
    }
}
