using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationHireInc.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookupType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentableProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentableProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentableProperty_LookupType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "LookupType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RentablePropertyId = table.Column<int>(type: "int", nullable: false),
                    RentStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RentEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DamagePresented = table.Column<bool>(type: "bit", nullable: false),
                    DamageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TankFilledUp = table.Column<bool>(type: "bit", nullable: false),
                    PriceUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_RentableProperty_RentablePropertyId",
                        column: x => x.RentablePropertyId,
                        principalTable: "RentableProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "United States, Street 1", "Elon Musk", "1234567890" },
                    { 2, "United States, Street 2", "Jeff Bezos", "2234567890" },
                    { 3, "France, Street 3", "Bernard Arnault", "3234567890" },
                    { 4, "United States, Street 4", "Bill Gates", "4234567890" },
                    { 5, "United States, Street 5", "Warren Buffett", "5234567890" }
                });

            migrationBuilder.InsertData(
                table: "LookupType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Truck" },
                    { 2, "Minivan" },
                    { 3, "Sedan" }
                });

            migrationBuilder.InsertData(
                table: "RentableProperty",
                columns: new[] { "Id", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, "Iveco Daily", 1 },
                    { 2, "Ford Transit", 1 },
                    { 3, "Isuzu", 1 },
                    { 4, "Mercedes Vito", 2 },
                    { 5, "Ford S-Max", 2 },
                    { 6, "Fiat Doblo", 2 },
                    { 7, "Toyota Corolla", 3 },
                    { 8, "Mazda 3", 3 },
                    { 9, "Volkswagen Passat", 3 },
                    { 10, "Renault Megane", 3 },
                    { 11, "Audi A3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId", "DamageDetails", "DamagePresented", "PriceCurrency", "PriceUnit", "RentEndDate", "RentStartDate", "RentablePropertyId", "TankFilledUp" },
                values: new object[] { 1, 1, null, false, "USD", 210m, new DateTime(2022, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 15, 11, 30, 0, 0, DateTimeKind.Unspecified), 11, true });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId", "DamageDetails", "DamagePresented", "PriceCurrency", "PriceUnit", "RentEndDate", "RentStartDate", "RentablePropertyId", "TankFilledUp" },
                values: new object[] { 2, 4, null, false, "USD", 900m, new DateTime(2022, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), 4, false });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId", "DamageDetails", "DamagePresented", "PriceCurrency", "PriceUnit", "RentEndDate", "RentStartDate", "RentablePropertyId", "TankFilledUp" },
                values: new object[] { 3, 5, null, false, "USD", 420m, new DateTime(2022, 5, 5, 10, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), 9, true });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_RentablePropertyId",
                table: "Order",
                column: "RentablePropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_RentableProperty_TypeId",
                table: "RentableProperty",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "RentableProperty");

            migrationBuilder.DropTable(
                name: "LookupType");
        }
    }
}
