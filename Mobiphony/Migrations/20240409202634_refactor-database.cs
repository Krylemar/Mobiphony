using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Mobiphony.Migrations
{
    /// <inheritdoc />
    public partial class refactordatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<sbyte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DisplayMatrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MatrixType = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayMatrices", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "longtext", nullable: false),
                    Length = table.Column<double>(type: "double", nullable: false),
                    Width = table.Column<double>(type: "double", nullable: false),
                    Thickness = table.Column<double>(type: "double", nullable: false),
                    SIM = table.Column<int>(type: "int", nullable: false),
                    IPRating = table.Column<int>(type: "int", nullable: false),
                    DisplaySize = table.Column<double>(type: "double", nullable: false),
                    Matrix = table.Column<double>(type: "double", nullable: false),
                    RefreshRate = table.Column<double>(type: "double", nullable: false),
                    Brightness = table.Column<double>(type: "double", nullable: false),
                    Resolution = table.Column<double>(type: "double", nullable: false),
                    ScreenProtection = table.Column<string>(type: "longtext", nullable: true),
                    Chipset = table.Column<string>(type: "longtext", nullable: true),
                    CPU = table.Column<string>(type: "longtext", nullable: true),
                    GPU = table.Column<string>(type: "longtext", nullable: true),
                    RAM = table.Column<int>(type: "int", nullable: false),
                    InternalStorage = table.Column<double>(type: "double", nullable: false),
                    ExpStorageLimit = table.Column<double>(type: "double", nullable: false),
                    USBType = table.Column<string>(type: "longtext", nullable: true),
                    FingerPrint = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FaceRec = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BatCapacity = table.Column<int>(type: "int", nullable: false),
                    BatChargingWattage = table.Column<int>(type: "int", nullable: false),
                    MainCamPhoto = table.Column<double>(type: "double", nullable: false),
                    MainCamVideo = table.Column<string>(type: "longtext", nullable: true),
                    MainCamFeatures = table.Column<string>(type: "longtext", nullable: true),
                    SelfCamPhoto = table.Column<double>(type: "double", nullable: false),
                    SselfCamVideo = table.Column<string>(type: "longtext", nullable: true),
                    SCFeatures = table.Column<string>(type: "longtext", nullable: true),
                    OS = table.Column<string>(type: "longtext", nullable: true),
                    WiFiSpeed = table.Column<double>(type: "double", nullable: false),
                    BluetoothVersion = table.Column<double>(type: "double", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false),
                    PurchaseLink = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhoneFeature",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneFeature", x => new { x.PhoneId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_PhoneFeature_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneFeature_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneFeature_FeatureId",
                table: "PhoneFeature",
                column: "FeatureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "DisplayMatrices");

            migrationBuilder.DropTable(
                name: "PhoneFeature");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
