using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Mobiphony.Migrations
{
    /// <inheritdoc />
    public partial class rework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(type: "longtext", nullable: false),
                    Length = table.Column<double>(type: "double", nullable: false),
                    Width = table.Column<double>(type: "double", nullable: false),
                    Thickness = table.Column<double>(type: "double", nullable: false),
                    SIM = table.Column<int>(type: "int", nullable: false),
                    IPRating = table.Column<int>(type: "int", nullable: false),
                    Dsize = table.Column<double>(type: "double", nullable: false),
                    Matrix = table.Column<double>(type: "double", nullable: false),
                    RefreshRate = table.Column<double>(type: "double", nullable: false),
                    Brightness = table.Column<double>(type: "double", nullable: false),
                    Resolution = table.Column<double>(type: "double", nullable: false),
                    ScrProtection = table.Column<string>(type: "longtext", nullable: true),
                    Chipset = table.Column<string>(type: "longtext", nullable: true),
                    CPU = table.Column<string>(type: "longtext", nullable: true),
                    GPU = table.Column<string>(type: "longtext", nullable: true),
                    RAM = table.Column<int>(type: "int", nullable: false),
                    InternalStorage = table.Column<double>(type: "double", nullable: false),
                    ExpStorageLimit = table.Column<double>(type: "double", nullable: false),
                    USBType = table.Column<string>(type: "longtext", nullable: true),
                    FingerPrint = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FaceRec = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BatCapacity = table.Column<double>(type: "double", nullable: false),
                    BatChargingWattage = table.Column<double>(type: "double", nullable: false),
                    MCMP = table.Column<double>(type: "double", nullable: false),
                    MCVideo = table.Column<string>(type: "longtext", nullable: true),
                    MCFeatures = table.Column<string>(type: "longtext", nullable: true),
                    SCMP = table.Column<double>(type: "double", nullable: false),
                    SCVideo = table.Column<string>(type: "longtext", nullable: true),
                    SCFeatures = table.Column<string>(type: "longtext", nullable: true),
                    OS = table.Column<string>(type: "longtext", nullable: true),
                    WiFiSpeed = table.Column<double>(type: "double", nullable: false),
                    BluetoothVersion = table.Column<double>(type: "double", nullable: false),
                    USBVersion = table.Column<double>(type: "double", nullable: false),
                    NFC = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
