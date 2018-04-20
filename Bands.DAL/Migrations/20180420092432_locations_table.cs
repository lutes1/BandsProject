using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bands.DAL.Migrations
{
    public partial class locations_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_PracticeLocations_PracticeLocationId",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PracticeLocations",
                table: "PracticeLocations");

            migrationBuilder.DropColumn(
                name: "PracticeLocationId",
                table: "PracticeLocations");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "PracticeLocations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "PracticeLocations");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Musicians");

            migrationBuilder.RenameColumn(
                name: "PracticeLocationId",
                table: "Pictures",
                newName: "PracticePalceMapLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_PracticeLocationId",
                table: "Pictures",
                newName: "IX_Pictures_PracticePalceMapLocationId");

            migrationBuilder.AddColumn<long>(
                name: "MapLocationId",
                table: "PracticeLocations",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "MapLocationId",
                table: "Musicians",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PracticeLocations",
                table: "PracticeLocations",
                column: "MapLocationId");

            migrationBuilder.CreateTable(
                name: "MapLocations",
                columns: table => new
                {
                    MapLocationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    Country = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapLocations", x => x.MapLocationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_MapLocationId",
                table: "Musicians",
                column: "MapLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicians_MapLocations_MapLocationId",
                table: "Musicians",
                column: "MapLocationId",
                principalTable: "MapLocations",
                principalColumn: "MapLocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_PracticeLocations_PracticePalceMapLocationId",
                table: "Pictures",
                column: "PracticePalceMapLocationId",
                principalTable: "PracticeLocations",
                principalColumn: "MapLocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PracticeLocations_MapLocations_MapLocationId",
                table: "PracticeLocations",
                column: "MapLocationId",
                principalTable: "MapLocations",
                principalColumn: "MapLocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicians_MapLocations_MapLocationId",
                table: "Musicians");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_PracticeLocations_PracticePalceMapLocationId",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticeLocations_MapLocations_MapLocationId",
                table: "PracticeLocations");

            migrationBuilder.DropTable(
                name: "MapLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PracticeLocations",
                table: "PracticeLocations");

            migrationBuilder.DropIndex(
                name: "IX_Musicians_MapLocationId",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "MapLocationId",
                table: "PracticeLocations");

            migrationBuilder.DropColumn(
                name: "MapLocationId",
                table: "Musicians");

            migrationBuilder.RenameColumn(
                name: "PracticePalceMapLocationId",
                table: "Pictures",
                newName: "PracticeLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_PracticePalceMapLocationId",
                table: "Pictures",
                newName: "IX_Pictures_PracticeLocationId");

            migrationBuilder.AddColumn<long>(
                name: "PracticeLocationId",
                table: "PracticeLocations",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Musicians",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PracticeLocations",
                table: "PracticeLocations",
                column: "PracticeLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_PracticeLocations_PracticeLocationId",
                table: "Pictures",
                column: "PracticeLocationId",
                principalTable: "PracticeLocations",
                principalColumn: "PracticeLocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
