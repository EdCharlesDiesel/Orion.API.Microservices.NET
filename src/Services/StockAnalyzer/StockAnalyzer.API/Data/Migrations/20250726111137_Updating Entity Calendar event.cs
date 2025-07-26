using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Services.StockAnalyzer.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingEntityCalendarevent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CalendarId",
                table: "CalendarEvents",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CalendarId",
                table: "CalendarEvents",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
