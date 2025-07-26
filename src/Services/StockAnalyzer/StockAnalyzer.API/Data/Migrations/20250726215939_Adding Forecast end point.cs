using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Services.StockAnalyzer.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingForecastendpoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComtradeCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParentId = table.Column<string>(type: "text", nullable: false),
                    PrettyName = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComtradeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forecast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LatestValue = table.Column<double>(type: "double precision", nullable: true),
                    LatestValueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ForecastValue1Q = table.Column<double>(type: "double precision", nullable: true),
                    ForecastValue2Q = table.Column<double>(type: "double precision", nullable: true),
                    ForecastValue3Q = table.Column<double>(type: "double precision", nullable: true),
                    ForecastValue4Q = table.Column<double>(type: "double precision", nullable: true),
                    ForecastValue1 = table.Column<double>(type: "double precision", nullable: true),
                    ForecastValue2 = table.Column<double>(type: "double precision", nullable: true),
                    ForecastValue3 = table.Column<double>(type: "double precision", nullable: true),
                    Q1_Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Q2_Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Q3_Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Q4_Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ForecastLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Frequency = table.Column<string>(type: "text", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: false),
                    HistoricalDataSymbol = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forecast", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComtradeCategories");

            migrationBuilder.DropTable(
                name: "Forecast");
        }
    }
}
