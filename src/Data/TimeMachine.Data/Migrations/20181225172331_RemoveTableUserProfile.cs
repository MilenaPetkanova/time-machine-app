using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeMachine.Data.Migrations
{
    public partial class RemoveTableUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserProfiles_UserProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Letters_UserProfiles_UserProfileId",
                table: "Letters");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_UserProfiles_UserProfileId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Stories_UserProfiles_UserProfileId",
                table: "Stories");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Stories_UserProfileId",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UserProfileId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Letters_UserProfileId",
                table: "Letters");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Stories",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Photos",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Letters",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Stories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Photos",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Stories",
                newName: "UserProfileId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Photos",
                newName: "UserProfileId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Letters",
                newName: "UserProfileId");

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_UserProfileId",
                table: "Stories",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserProfileId",
                table: "Photos",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_UserProfileId",
                table: "Letters",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserProfileId",
                table: "AspNetUsers",
                column: "UserProfileId",
                unique: true,
                filter: "[UserProfileId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserProfiles_UserProfileId",
                table: "AspNetUsers",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_UserProfiles_UserProfileId",
                table: "Letters",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_UserProfiles_UserProfileId",
                table: "Photos",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_UserProfiles_UserProfileId",
                table: "Stories",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
