using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarConstructorGame.DAL.Implementation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoneySum = table.Column<decimal>(type: "money", nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    GameRating = table.Column<string>(nullable: false),
                    Age_Value = table.Column<int>(nullable: true, defaultValue: 10)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMoving = table.Column<bool>(nullable: false, defaultValue: false),
                    Distance = table.Column<double>(nullable: false),
                    TotalCost = table.Column<decimal>(type: "money", nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    DetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSuitableForRepairing = table.Column<bool>(nullable: false, defaultValue: true),
                    RepairPrice = table.Column<decimal>(type: "money", nullable: false),
                    BuyPrice = table.Column<decimal>(type: "money", nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    DetailType = table.Column<int>(nullable: false),
                    ExpluatationStabilityCoef = table.Column<double>(nullable: false),
                    Power = table.Column<double>(nullable: true),
                    HoursOfWork = table.Column<TimeSpan>(nullable: true),
                    HorceForce = table.Column<double>(nullable: true),
                    CubicCapability = table.Column<double>(nullable: true),
                    Count = table.Column<int>(nullable: true, defaultValue: 4),
                    Diameter = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_Details_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CarId",
                table: "Details",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
