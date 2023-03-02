using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSSERVICE.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class LoginDetail2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isLocked",
                table: "LoginDetail",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "((0))");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isLocked",
                table: "LoginDetail",
                type: "bit",
                nullable: false,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "((0))");
        }
    }
}
