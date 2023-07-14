using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaProject.Data.Migrations
{
    public partial class actorImageFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageUrl",
                table: "Actors",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 22, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 7, 12, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 27, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1957), new DateTime(2023, 7, 12, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 22, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 8, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 20, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1966), new DateTime(2023, 7, 10, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 27, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1970), new DateTime(2023, 7, 15, 19, 6, 26, 161, DateTimeKind.Local).AddTicks(1969) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageUrl",
                table: "Actors",
                type: "nvarchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

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
        }
    }
}
