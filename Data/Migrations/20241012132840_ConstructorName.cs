using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveToGetDataWebsitePrototype.Migrations
{
    /// <inheritdoc />
    public partial class ConstructorName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConstructorName",
                table: "Constructors",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Constructors",
                newName: "ConstructorName");

        }
    }
}
