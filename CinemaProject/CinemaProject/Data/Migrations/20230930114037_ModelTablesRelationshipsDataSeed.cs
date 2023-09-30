using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaProject.Data.Migrations
{
    public partial class ModelTablesRelationshipsDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 9, 30, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 15, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 9, 30, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(9002), new DateTime(2023, 9, 26, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 8, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(9007), new DateTime(2023, 9, 28, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 15, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 10, 3, 13, 40, 37, 538, DateTimeKind.Local).AddTicks(9010) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 9, 30, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 15, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 9, 30, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 9, 26, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 8, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 9, 28, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 15, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 10, 3, 13, 36, 14, 975, DateTimeKind.Local).AddTicks(2821) });
        }
    }
}
