using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleIDToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Users");
        }
    }
}
