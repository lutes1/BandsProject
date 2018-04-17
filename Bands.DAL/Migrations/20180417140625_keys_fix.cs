using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bands.DAL.Migrations
{
    public partial class keys_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Picture_AspNetUsers_ApplicationUserId",
                table: "Picture");

            migrationBuilder.DropForeignKey(
                name: "FK_Picture_Bands_BandId",
                table: "Picture");

            migrationBuilder.DropIndex(
                name: "IX_Picture_ApplicationUserId",
                table: "Picture");

            migrationBuilder.DropIndex(
                name: "IX_Picture_BandId",
                table: "Picture");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Picture");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "Picture");

            migrationBuilder.AddColumn<long>(
                name: "PictureId",
                table: "Bands",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PictureId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Bands_PictureId",
                table: "Bands",
                column: "PictureId",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bands_Picture_PictureId",
                table: "Bands",
                column: "PictureId",
                principalTable: "Picture",
                principalColumn: "PictureId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Picture_PictureId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Bands_Picture_PictureId",
                table: "Bands");

            migrationBuilder.DropIndex(
                name: "IX_Bands_PictureId",
                table: "Bands");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PictureId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "Bands");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Picture",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BandId",
                table: "Picture",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Picture_ApplicationUserId",
                table: "Picture",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_BandId",
                table: "Picture",
                column: "BandId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_AspNetUsers_ApplicationUserId",
                table: "Picture",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_Bands_BandId",
                table: "Picture",
                column: "BandId",
                principalTable: "Bands",
                principalColumn: "BandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
