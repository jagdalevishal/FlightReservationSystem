using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FRS.Migrations
{
    /// <inheritdoc />
    public partial class addTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaneInfo",
                columns: table => new
                {
                    Planeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APlaneName = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneInfo", x => x.Planeid);
                });

            migrationBuilder.CreateTable(
                name: "TblAdminLogin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAdminLogin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "TblUserAccount",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<int>(type: "int", maxLength: 40, nullable: false),
                    LastName = table.Column<int>(type: "int", maxLength: 40, nullable: false),
                    EmailId = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Password = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CPassword = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phoneno = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUserAccount", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "TblFlightBook",
                columns: table => new
                {
                    bid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    To = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DTime = table.Column<DateTime>(type: "datetime2", maxLength: 15, nullable: false),
                    Planeid = table.Column<int>(type: "int", nullable: false),
                    PlaneInfoPlaneid = table.Column<int>(type: "int", nullable: false),
                    SeatType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFlightBook", x => x.bid);
                    table.ForeignKey(
                        name: "FK_TblFlightBook_PlaneInfo_PlaneInfoPlaneid",
                        column: x => x.PlaneInfoPlaneid,
                        principalTable: "PlaneInfo",
                        principalColumn: "Planeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblFlightBook_PlaneInfoPlaneid",
                table: "TblFlightBook",
                column: "PlaneInfoPlaneid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAdminLogin");

            migrationBuilder.DropTable(
                name: "TblFlightBook");

            migrationBuilder.DropTable(
                name: "TblUserAccount");

            migrationBuilder.DropTable(
                name: "PlaneInfo");
        }
    }
}
