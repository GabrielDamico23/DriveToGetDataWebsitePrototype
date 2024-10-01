using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveToGetDataWebsitePrototype.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDriver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "albon",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "alonso",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "bearman",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "bottas",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "colapinto",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "deVries",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "gasly",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "Guanyu",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "hamilton",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "hulkenberg",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "latifi",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "lawson",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "leclerc",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "magnussen",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "norris",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "ocon",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "perez",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "piastri",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "ricciardo",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "russell",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "sainz",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "sargeant",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "schumacher",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "stroll",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "tsunoda",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "verstappen",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "vettel",
                column: "Image",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Drivers");
        }
    }
}
