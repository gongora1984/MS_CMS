using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSSERVICE.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClientDptTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientDepartment_Client_ClientId1",
                table: "ClientDepartment");

            migrationBuilder.DropIndex(
                name: "IX_ClientDepartment_ClientId1",
                table: "ClientDepartment");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "ClientDepartment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "ClientDepartment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientDepartment_ClientId1",
                table: "ClientDepartment",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientDepartment_Client_ClientId1",
                table: "ClientDepartment",
                column: "ClientId1",
                principalTable: "Client",
                principalColumn: "ClientId");
        }
    }
}
