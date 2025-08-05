using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Services.Order.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderNumber = table.Column<string>(type: "text", nullable: true),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<string>(type: "text", nullable: true),
                    PublishedDate = table.Column<string>(type: "text", nullable: true),
                    RetailPrice = table.Column<string>(type: "text", nullable: true),
                    CoverFileName = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    InventoryStatus = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderId",
                table: "Product",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
