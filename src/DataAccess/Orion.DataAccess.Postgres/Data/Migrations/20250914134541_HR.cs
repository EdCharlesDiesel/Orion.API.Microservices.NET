using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.DataAccess.Postgres.Data.Migrations
{
    /// <inheritdoc />
    public partial class HR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddress_HumanResources.Employee_EmployeeId",
                table: "EmployeeAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddress_Person.Address_AddressId",
                table: "EmployeeAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Production.ProductDocument_Production.Document_DocumentId",
                table: "Production.ProductDocument");

            migrationBuilder.DropTable(
                name: "CalendarEvent");

            migrationBuilder.DropIndex(
                name: "IX_Production.ProductDocument_DocumentId",
                table: "Production.ProductDocument");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production.Document",
                table: "Production.Document");

            migrationBuilder.DropIndex(
                name: "IX_Production.Document_BusinessEntityID",
                table: "Production.Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorContact",
                table: "VendorContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorAddress",
                table: "VendorAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreContact",
                table: "StoreContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Individual",
                table: "Individual");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forecast",
                table: "Forecast");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeAddress",
                table: "EmployeeAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactCreditCard",
                table: "ContactCreditCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Production.ProductDocument");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Production.Document");

            migrationBuilder.RenameTable(
                name: "VendorContact",
                newName: "VendorContacts");

            migrationBuilder.RenameTable(
                name: "VendorAddress",
                newName: "VendorAddresses");

            migrationBuilder.RenameTable(
                name: "StoreContact",
                newName: "StoreContacts");

            migrationBuilder.RenameTable(
                name: "Individual",
                newName: "Individuals");

            migrationBuilder.RenameTable(
                name: "Forecast",
                newName: "Forecasts");

            migrationBuilder.RenameTable(
                name: "EmployeeAddress",
                newName: "EmployeeAddresses");

            migrationBuilder.RenameTable(
                name: "CustomerAddress",
                newName: "CustomerAddresses");

            migrationBuilder.RenameTable(
                name: "ContactCreditCard",
                newName: "ContactCreditCards");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeAddress_EmployeeId",
                table: "EmployeeAddresses",
                newName: "IX_EmployeeAddresses_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeAddress_AddressId",
                table: "EmployeeAddresses",
                newName: "IX_EmployeeAddresses_AddressId");

            migrationBuilder.AddColumn<int>(
                name: "DocumentBusinessEntityID",
                table: "Production.ProductDocument",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityVersion",
                table: "HumanResources.Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "HumanResources.Employee",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "JobLevel",
                table: "HumanResources.Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "MinimumRaiseGiven",
                table: "HumanResources.Employee",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "HumanResources.Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuggestedBonus",
                table: "HumanResources.Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsInService",
                table: "HumanResources.Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ErrorProcedure",
                table: "ErrorLog",
                type: "character varying(126)",
                maxLength: 126,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(126)",
                oldMaxLength: 126);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production.Document",
                table: "Production.Document",
                column: "BusinessEntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorContacts",
                table: "VendorContacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorAddresses",
                table: "VendorAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreContacts",
                table: "StoreContacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Individuals",
                table: "Individuals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forecasts",
                table: "Forecasts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeAddresses",
                table: "EmployeeAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAddresses",
                table: "CustomerAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactCreditCards",
                table: "ContactCreditCards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    DurationInMinutes = table.Column<int>(type: "integer", nullable: false),
                    IsMandatory = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    EmployeeBusinessEntityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_HumanResources.Employee_EmployeeBusinessEntityID",
                        column: x => x.EmployeeBusinessEntityID,
                        principalTable: "HumanResources.Employee",
                        principalColumn: "BusinessEntityID");
                });

            migrationBuilder.CreateTable(
                name: "OrionCalendarEvent",
                columns: table => new
                {
                    OrionCalendarEventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeID = table.Column<int>(name: "Employee ID", type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReferenceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    JobLevel = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Salary = table.Column<decimal>(type: "numeric", nullable: false),
                    SuggestedBonus = table.Column<decimal>(type: "numeric", nullable: false),
                    YearsInService = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrionCalendarEvent", x => x.OrionCalendarEventID);
                });

            migrationBuilder.CreateTable(
                name: "TradingEconomicsCalendar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CalendarId = table.Column<string>(type: "text", nullable: false),
                    Importance = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Event = table.Column<string>(type: "text", nullable: false),
                    Source = table.Column<string>(type: "text", nullable: false),
                    SourceUrl = table.Column<string>(type: "text", nullable: false),
                    Actual = table.Column<string>(type: "text", nullable: false),
                    Previous = table.Column<string>(type: "text", nullable: false),
                    Forecast = table.Column<string>(type: "text", nullable: false),
                    TeForecast = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    DateSpan = table.Column<string>(type: "text", nullable: false),
                    Revised = table.Column<string>(type: "text", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: false),
                    Ticker = table.Column<string>(type: "text", nullable: false),
                    Symbol = table.Column<string>(type: "text", nullable: false),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReferenceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradingEconomicsCalendar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Production.ProductDocument_DocumentBusinessEntityID",
                table: "Production.ProductDocument",
                column: "DocumentBusinessEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_EmployeeBusinessEntityID",
                table: "Courses",
                column: "EmployeeBusinessEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddresses_HumanResources.Employee_EmployeeId",
                table: "EmployeeAddresses",
                column: "EmployeeId",
                principalTable: "HumanResources.Employee",
                principalColumn: "BusinessEntityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddresses_Person.Address_AddressId",
                table: "EmployeeAddresses",
                column: "AddressId",
                principalTable: "Person.Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production.ProductDocument_Production.Document_DocumentBusi~",
                table: "Production.ProductDocument",
                column: "DocumentBusinessEntityID",
                principalTable: "Production.Document",
                principalColumn: "BusinessEntityID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddresses_HumanResources.Employee_EmployeeId",
                table: "EmployeeAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddresses_Person.Address_AddressId",
                table: "EmployeeAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Production.ProductDocument_Production.Document_DocumentBusi~",
                table: "Production.ProductDocument");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "OrionCalendarEvent");

            migrationBuilder.DropTable(
                name: "TradingEconomicsCalendar");

            migrationBuilder.DropIndex(
                name: "IX_Production.ProductDocument_DocumentBusinessEntityID",
                table: "Production.ProductDocument");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production.Document",
                table: "Production.Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorContacts",
                table: "VendorContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorAddresses",
                table: "VendorAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreContacts",
                table: "StoreContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Individuals",
                table: "Individuals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forecasts",
                table: "Forecasts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeAddresses",
                table: "EmployeeAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAddresses",
                table: "CustomerAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactCreditCards",
                table: "ContactCreditCards");

            migrationBuilder.DropColumn(
                name: "DocumentBusinessEntityID",
                table: "Production.ProductDocument");

            migrationBuilder.DropColumn(
                name: "EntityVersion",
                table: "HumanResources.Employee");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HumanResources.Employee");

            migrationBuilder.DropColumn(
                name: "JobLevel",
                table: "HumanResources.Employee");

            migrationBuilder.DropColumn(
                name: "MinimumRaiseGiven",
                table: "HumanResources.Employee");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "HumanResources.Employee");

            migrationBuilder.DropColumn(
                name: "SuggestedBonus",
                table: "HumanResources.Employee");

            migrationBuilder.DropColumn(
                name: "YearsInService",
                table: "HumanResources.Employee");

            migrationBuilder.RenameTable(
                name: "VendorContacts",
                newName: "VendorContact");

            migrationBuilder.RenameTable(
                name: "VendorAddresses",
                newName: "VendorAddress");

            migrationBuilder.RenameTable(
                name: "StoreContacts",
                newName: "StoreContact");

            migrationBuilder.RenameTable(
                name: "Individuals",
                newName: "Individual");

            migrationBuilder.RenameTable(
                name: "Forecasts",
                newName: "Forecast");

            migrationBuilder.RenameTable(
                name: "EmployeeAddresses",
                newName: "EmployeeAddress");

            migrationBuilder.RenameTable(
                name: "CustomerAddresses",
                newName: "CustomerAddress");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "ContactCreditCards",
                newName: "ContactCreditCard");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeAddresses_EmployeeId",
                table: "EmployeeAddress",
                newName: "IX_EmployeeAddress_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeAddresses_AddressId",
                table: "EmployeeAddress",
                newName: "IX_EmployeeAddress_AddressId");

            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "Production.ProductDocument",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Production.Document",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "ErrorProcedure",
                table: "ErrorLog",
                type: "character varying(126)",
                maxLength: 126,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(126)",
                oldMaxLength: 126,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production.Document",
                table: "Production.Document",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorContact",
                table: "VendorContact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorAddress",
                table: "VendorAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreContact",
                table: "StoreContact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Individual",
                table: "Individual",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forecast",
                table: "Forecast",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeAddress",
                table: "EmployeeAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactCreditCard",
                table: "ContactCreditCard",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CalendarEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Actual = table.Column<string>(type: "text", nullable: false),
                    CalendarId = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateSpan = table.Column<string>(type: "text", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Event = table.Column<string>(type: "text", nullable: false),
                    Forecast = table.Column<string>(type: "text", nullable: false),
                    Importance = table.Column<int>(type: "integer", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Previous = table.Column<string>(type: "text", nullable: false),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    ReferenceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Revised = table.Column<string>(type: "text", nullable: false),
                    Source = table.Column<string>(type: "text", nullable: false),
                    SourceUrl = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Symbol = table.Column<string>(type: "text", nullable: false),
                    TeForecast = table.Column<string>(type: "text", nullable: false),
                    Ticker = table.Column<string>(type: "text", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarEvent", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Production.ProductDocument_DocumentId",
                table: "Production.ProductDocument",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Production.Document_BusinessEntityID",
                table: "Production.Document",
                column: "BusinessEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddress_HumanResources.Employee_EmployeeId",
                table: "EmployeeAddress",
                column: "EmployeeId",
                principalTable: "HumanResources.Employee",
                principalColumn: "BusinessEntityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddress_Person.Address_AddressId",
                table: "EmployeeAddress",
                column: "AddressId",
                principalTable: "Person.Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production.ProductDocument_Production.Document_DocumentId",
                table: "Production.ProductDocument",
                column: "DocumentId",
                principalTable: "Production.Document",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
