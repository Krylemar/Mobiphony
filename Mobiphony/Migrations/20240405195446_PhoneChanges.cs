using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobiphony.Migrations
{
    /// <inheritdoc />
    public partial class PhoneChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Phones");
        }
    }
}
