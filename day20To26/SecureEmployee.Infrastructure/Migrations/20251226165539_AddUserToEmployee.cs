using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecureEmployee.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Employees",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "PasswordHash",
                value: "$2a$11$rFKVbXQQXPCXwacXY4SOo.Uq6eUvF9qA.5naTL3pjQauGFwhvposm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "PasswordHash",
                value: "$2a$11$NcJKGRurcWAEK/P/hP7wj.zzmPYMA8eeECCMy8LFrxtdGw5c6EV9G");
        }
    }
}
