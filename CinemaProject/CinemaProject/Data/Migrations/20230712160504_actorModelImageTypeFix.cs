using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaProject.Data.Migrations
{
    public partial class actorModelImageTypeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageUrl",
                table: "Actors",
                type: "nvarchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 22, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(525), new DateTime(2023, 7, 12, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 27, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(534), new DateTime(2023, 7, 12, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 22, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 7, 8, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 20, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(544), new DateTime(2023, 7, 10, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 27, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 7, 15, 18, 5, 3, 850, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfileImageUrl",
                value: "james_cameron.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageUrl",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 7, 6, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 21, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 7, 6, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2782), new DateTime(2023, 7, 2, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 14, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 7, 4, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 21, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 7, 9, 8, 24, 12, 514, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfileImageUrl",
                value: "james_cameron.jpg");
        }
    }
}
