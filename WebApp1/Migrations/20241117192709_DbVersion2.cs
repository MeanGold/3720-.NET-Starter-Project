using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Migrations
{
    /// <inheritdoc />
    public partial class DbVersion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CUID_number",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CUID_number",
                table: "Users");
        }
    }
}
