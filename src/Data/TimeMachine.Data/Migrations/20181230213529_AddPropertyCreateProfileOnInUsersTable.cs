using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeMachine.Data.Migrations
{
    public partial class AddPropertyCreateProfileOnInUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateProfileOn",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateProfileOn",
                table: "AspNetUsers");
        }
    }
}
