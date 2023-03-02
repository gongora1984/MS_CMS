using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSSERVICE.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class JobTypeTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTemplateId",
                table: "JobType");

            migrationBuilder.AlterColumn<string>(
                name: "JobTemplateLocation",
                table: "JobType",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: true,
                defaultValueSql: "(' ')",
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300,
                oldDefaultValueSql: "(' ')");

            migrationBuilder.AlterColumn<string>(
                name: "JobState",
                table: "JobType",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "JobPKField",
                table: "JobType",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "JobDataTable",
                table: "JobType",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "JobClientRefField",
                table: "JobType",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                defaultValueSql: "('PKID')",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('PKID')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobTemplateLocation",
                table: "JobType",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                defaultValueSql: "(' ')",
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300,
                oldNullable: true,
                oldDefaultValueSql: "(' ')");

            migrationBuilder.AlterColumn<string>(
                name: "JobState",
                table: "JobType",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: false,
                defaultValue: string.Empty,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobPKField",
                table: "JobType",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: string.Empty,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobDataTable",
                table: "JobType",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: string.Empty,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobClientRefField",
                table: "JobType",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('PKID')",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "('PKID')");

            migrationBuilder.AddColumn<int>(
                name: "JobTemplateId",
                table: "JobType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
