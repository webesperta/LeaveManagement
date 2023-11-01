using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 9, 23, 4, 46, 59, 627, DateTimeKind.Local).AddTicks(5960), new DateTime(2023, 9, 23, 4, 46, 59, 627, DateTimeKind.Local).AddTicks(5975) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 9, 3, 565, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 9, 22, 0, 9, 3, 565, DateTimeKind.Local).AddTicks(6670) });
        }
    }
}
