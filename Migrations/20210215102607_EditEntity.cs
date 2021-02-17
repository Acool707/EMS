using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.Migrations
{
    public partial class EditEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PermissionType = table.Column<int>(type: "INTEGER", nullable: false),
                    AppUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permission_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserHoliday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HolidayDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AppUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHoliday", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHoliday_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInOutTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserInTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserOutTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AppUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInOutTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInOutTime_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLeaveApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ApplicationTile = table.Column<string>(type: "TEXT", nullable: true),
                    ApplicationDetails = table.Column<string>(type: "TEXT", nullable: true),
                    LeaveAppliedFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LeaveAppliedTo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LeaveApprovalStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    LeaveApprovedBy = table.Column<int>(type: "INTEGER", nullable: false),
                    AppUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLeaveApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLeaveApplication_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Website",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WebsiteType = table.Column<int>(type: "INTEGER", nullable: false),
                    AppUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Website", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Website_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permission_AppUserId",
                table: "Permission",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHoliday_AppUserId",
                table: "UserHoliday",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInOutTime_AppUserId",
                table: "UserInOutTime",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaveApplication_AppUserId",
                table: "UserLeaveApplication",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Website_AppUserId",
                table: "Website",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "UserHoliday");

            migrationBuilder.DropTable(
                name: "UserInOutTime");

            migrationBuilder.DropTable(
                name: "UserLeaveApplication");

            migrationBuilder.DropTable(
                name: "Website");
        }
    }
}
