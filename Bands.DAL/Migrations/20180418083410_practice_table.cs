using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bands.DAL.Migrations
{
    public partial class practice_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PracticeLocationId",
                table: "Picture",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PracticeLocations",
                columns: table => new
                {
                    PracticeLocationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    GoolleMapsAddress = table.Column<string>(maxLength: 1000, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    OwnerFullName = table.Column<string>(maxLength: 40, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeLocations", x => x.PracticeLocationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Picture_PracticeLocationId",
                table: "Picture",
                column: "PracticeLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_PracticeLocations_PracticeLocationId",
                table: "Picture",
                column: "PracticeLocationId",
                principalTable: "PracticeLocations",
                principalColumn: "PracticeLocationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Picture_PracticeLocations_PracticeLocationId",
                table: "Picture");

            migrationBuilder.DropTable(
                name: "PracticeLocations");

            migrationBuilder.DropIndex(
                name: "IX_Picture_PracticeLocationId",
                table: "Picture");

            migrationBuilder.DropColumn(
                name: "PracticeLocationId",
                table: "Picture");
        }
    }
}
