using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api08.Migrations
{
    public partial class addDateModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Person",
                nullable: false,
                defaultValue: new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Department",
                nullable: false,
                defaultValue: new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Course",
                nullable: false,
                defaultValue: new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Course");
        }
    }
}
