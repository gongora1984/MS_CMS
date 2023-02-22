using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSSERVICE.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLoginDetailTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AccessToken",
                table: "LoginDetail",
                type: "varchar(2500)",
                unicode: false,
                maxLength: 2500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2500)",
                oldUnicode: false,
                oldMaxLength: 2500);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AccessToken",
                table: "LoginDetail",
                type: "varchar(2500)",
                unicode: false,
                maxLength: 2500,
                nullable: false,
                defaultValue: string.Empty,
                oldClrType: typeof(string),
                oldType: "varchar(2500)",
                oldUnicode: false,
                oldMaxLength: 2500,
                oldNullable: true);
        }
    }
}
