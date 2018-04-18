using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bands.DAL.Migrations
{
    public partial class account_pic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Picture_PictureId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PictureId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<long>(
                name: "PictureId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PictureId",
                table: "AspNetUsers",
                column: "PictureId",
                unique: true,
                filter: "[PictureId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Picture_PictureId",
                table: "AspNetUsers",
                column: "PictureId",
                principalTable: "Picture",
                principalColumn: "PictureId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Picture_PictureId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PictureId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<long>(
                name: "PictureId",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PictureId",
                table: "AspNetUsers",
                column: "PictureId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Picture_PictureId",
                table: "AspNetUsers",
                column: "PictureId",
                principalTable: "Picture",
                principalColumn: "PictureId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
