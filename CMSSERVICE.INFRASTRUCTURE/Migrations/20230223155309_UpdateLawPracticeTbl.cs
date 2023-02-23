using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSSERVICE.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLawPracticeTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LawPracticeUserID",
                table: "LawPractice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LawPracticeUserID",
                table: "LawPractice",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
