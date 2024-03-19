using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobiphony.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Thickness = table.Column<double>(type: "float", nullable: false),
                    SIM = table.Column<int>(type: "int", nullable: false),
                    IPRating = table.Column<int>(type: "int", nullable: false),
                    Dsize = table.Column<double>(type: "float", nullable: false),
                    Matrix = table.Column<double>(type: "float", nullable: false),
                    RefreshRate = table.Column<double>(type: "float", nullable: false),
                    Brightness = table.Column<double>(type: "float", nullable: false),
                    Resolution = table.Column<double>(type: "float", nullable: false),
                    ScrProtection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<int>(type: "int", nullable: false),
                    InternalStorage = table.Column<double>(type: "float", nullable: false),
                    ExpStorageLimit = table.Column<double>(type: "float", nullable: false),
                    USBType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FingerPrint = table.Column<bool>(type: "bit", nullable: false),
                    FaceRec = table.Column<bool>(type: "bit", nullable: false),
                    BatCapacity = table.Column<double>(type: "float", nullable: false),
                    BatChargingWattage = table.Column<double>(type: "float", nullable: false),
                    MCMP = table.Column<double>(type: "float", nullable: false),
                    MCVideo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MCFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SCMP = table.Column<double>(type: "float", nullable: false),
                    SCVideo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SCFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WiFiSpeed = table.Column<double>(type: "float", nullable: false),
                    BluetoothVersion = table.Column<double>(type: "float", nullable: false),
                    USBVersion = table.Column<double>(type: "float", nullable: false),
                    NFC = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) // This is basicly a rollback if Up func fails
        {
            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
