using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeMachine.Data.Migrations
{
    public partial class ChangeUserIdNavigationPropertiesToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Letters_AspNetUsers_UserId1",
                table: "Letters");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_AspNetUsers_UserId1",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Stories_AspNetUsers_UserId1",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Stories_UserId1",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UserId1",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Letters_UserId1",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Letters");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Stories",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Photos",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Letters",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stories_UserId",
                table: "Stories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_UserId",
                table: "Letters",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_AspNetUsers_UserId",
                table: "Letters",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_AspNetUsers_UserId",
                table: "Photos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_AspNetUsers_UserId",
                table: "Stories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Letters_AspNetUsers_UserId",
                table: "Letters");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_AspNetUsers_UserId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Stories_AspNetUsers_UserId",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Stories_UserId",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UserId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Letters_UserId",
                table: "Letters");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Stories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Stories",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Photos",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Photos",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Letters",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Letters",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stories_UserId1",
                table: "Stories",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId1",
                table: "Photos",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_UserId1",
                table: "Letters",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_AspNetUsers_UserId1",
                table: "Letters",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_AspNetUsers_UserId1",
                table: "Photos",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_AspNetUsers_UserId1",
                table: "Stories",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
