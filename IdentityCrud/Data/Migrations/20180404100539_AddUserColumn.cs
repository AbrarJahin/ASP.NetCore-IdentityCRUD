using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IdentityCrud.Migrations
{
    public partial class AddUserColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddId",
                table: "ProductType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateId",
                table: "ProductType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddId",
                table: "ProductCategory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateId",
                table: "ProductCategory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddId",
                table: "Exits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateId",
                table: "Exits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddId",
                table: "Entry",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateId",
                table: "Entry",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "LastUpdateId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "AddId",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "LastUpdateId",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "AddId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LastUpdateId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "AddId",
                table: "Exits");

            migrationBuilder.DropColumn(
                name: "LastUpdateId",
                table: "Exits");

            migrationBuilder.DropColumn(
                name: "AddId",
                table: "Entry");

            migrationBuilder.DropColumn(
                name: "LastUpdateId",
                table: "Entry");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "AspNetUsers");
        }
    }
}
