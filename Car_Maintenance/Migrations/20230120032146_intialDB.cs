using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarMaintenance.Migrations
{
    /// <inheritdoc />
    public partial class intialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONGVIEC",
                columns: table => new
                {
                    MACV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TENCV = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DONGIA = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONGVIEC", x => x.MACV);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    MAKH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HOTENKH = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DIENTHOAI = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANG", x => x.MAKH);
                });

            migrationBuilder.CreateTable(
                name: "XE",
                columns: table => new
                {
                    SOXE = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HANGXE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NAMSX = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    MAKH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XE", x => x.SOXE);
                    table.ForeignKey(
                        name: "FK_XE_KHACHHANG",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                });

            migrationBuilder.CreateTable(
                name: "BAODUONG",
                columns: table => new
                {
                    MABD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NGAYGIONHAN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NGAYGIOTRA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SOKM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NOIDUNG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SOXE = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAODUONG", x => x.MABD);
                    table.ForeignKey(
                        name: "FK_BAODUONG_XE",
                        column: x => x.SOXE,
                        principalTable: "XE",
                        principalColumn: "SOXE");
                });

            migrationBuilder.CreateTable(
                name: "CT_BD",
                columns: table => new
                {
                    Mabd = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Macv = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_BD", x => new { x.Mabd, x.Macv });
                    table.ForeignKey(
                        name: "FK_CT_BD_BAODUONG",
                        column: x => x.Mabd,
                        principalTable: "BAODUONG",
                        principalColumn: "MABD");
                    table.ForeignKey(
                        name: "FK_CT_BD_CONGVIEC",
                        column: x => x.Macv,
                        principalTable: "CONGVIEC",
                        principalColumn: "MACV");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BAODUONG_SOXE",
                table: "BAODUONG",
                column: "SOXE");

            migrationBuilder.CreateIndex(
                name: "IX_CT_BD_Macv",
                table: "CT_BD",
                column: "Macv");

            migrationBuilder.CreateIndex(
                name: "IX_XE_MAKH",
                table: "XE",
                column: "MAKH");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CT_BD");

            migrationBuilder.DropTable(
                name: "BAODUONG");

            migrationBuilder.DropTable(
                name: "CONGVIEC");

            migrationBuilder.DropTable(
                name: "XE");

            migrationBuilder.DropTable(
                name: "KHACHHANG");
        }
    }
}
