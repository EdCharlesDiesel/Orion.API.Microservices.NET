using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Services.UserProfile.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "UserProfiles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "UserProfiles",
                type: "text",
                nullable: true);
        }
    }
}
