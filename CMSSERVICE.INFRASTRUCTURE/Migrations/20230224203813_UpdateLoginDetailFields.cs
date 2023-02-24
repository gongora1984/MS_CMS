using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSSERVICE.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLoginDetailFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isLocked",
                table: "LoginDetail",
                type: "bit",
                nullable: false,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "LoginPWD",
                table: "LoginDetail",
                type: "varchar(1500)",
                unicode: false,
                maxLength: 1500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldUnicode: false,
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "AccessToken",
                table: "LoginDetail",
                type: "varchar(3500)",
                unicode: false,
                maxLength: 3500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2500)",
                oldUnicode: false,
                oldMaxLength: 2500,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isLocked",
                table: "LoginDetail",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "((0))");

            migrationBuilder.AlterColumn<string>(
                name: "LoginPWD",
                table: "LoginDetail",
                type: "varchar(500)",
                unicode: false,
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1500)",
                oldUnicode: false,
                oldMaxLength: 1500);

            migrationBuilder.AlterColumn<string>(
                name: "AccessToken",
                table: "LoginDetail",
                type: "varchar(2500)",
                unicode: false,
                maxLength: 2500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3500)",
                oldUnicode: false,
                oldMaxLength: 3500,
                oldNullable: true);
        }
    }
}
