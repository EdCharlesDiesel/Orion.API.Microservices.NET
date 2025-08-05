using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Services.UserProfile.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class WorkingOnCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "IsLoggedIn",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Subscription",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                table: "UserProfiles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "UserProfiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Code",
                table: "UserProfiles",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdNumber",
                table: "UserProfiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "UserProfiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsLoggedIn",
                table: "UserProfiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "UserProfiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "UserProfiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subscription",
                table: "UserProfiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserTypeId",
                table: "UserProfiles",
                type: "text",
                nullable: true);
        }
    }
}
