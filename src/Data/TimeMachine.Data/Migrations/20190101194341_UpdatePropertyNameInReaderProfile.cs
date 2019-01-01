using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeMachine.Data.Migrations
{
    public partial class UpdatePropertyNameInReaderProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userId",
                table: "ReaderProfiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "ReaderProfiles",
                nullable: true);
        }
    }
}
