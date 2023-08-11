using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionArchitectureExample.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedByUpdateDateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Denemes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Denemes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Customers");
        }
    }
}
