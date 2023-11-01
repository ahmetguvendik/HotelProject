using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookButtonText",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "DetailButtonText",
                table: "Rooms",
                newName: "ImagePath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Rooms",
                newName: "DetailButtonText");

            migrationBuilder.AddColumn<string>(
                name: "BookButtonText",
                table: "Rooms",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
