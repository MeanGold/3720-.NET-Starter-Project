using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Migrations
{
    /// <inheritdoc />
    public partial class TicketsDBv02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_theEventId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_theCustomerId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_theCustomerId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_theEventId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "theEventId",
                table: "Tickets",
                newName: "eventID");

            migrationBuilder.RenameColumn(
                name: "theCustomerId",
                table: "Tickets",
                newName: "customerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "eventID",
                table: "Tickets",
                newName: "theEventId");

            migrationBuilder.RenameColumn(
                name: "customerID",
                table: "Tickets",
                newName: "theCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_theCustomerId",
                table: "Tickets",
                column: "theCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_theEventId",
                table: "Tickets",
                column: "theEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_theEventId",
                table: "Tickets",
                column: "theEventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_theCustomerId",
                table: "Tickets",
                column: "theCustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
