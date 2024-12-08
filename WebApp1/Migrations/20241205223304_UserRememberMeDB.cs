using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Migrations
{
    /// <inheritdoc />
    public partial class UserRememberMeDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_customerId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Tickets",
                newName: "theCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_customerId",
                table: "Tickets",
                newName: "IX_Tickets_theCustomerId");

            migrationBuilder.AddColumn<bool>(
                name: "remember_me",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_theCustomerId",
                table: "Tickets",
                column: "theCustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_theCustomerId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "remember_me",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "theCustomerId",
                table: "Tickets",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_theCustomerId",
                table: "Tickets",
                newName: "IX_Tickets_customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_customerId",
                table: "Tickets",
                column: "customerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
