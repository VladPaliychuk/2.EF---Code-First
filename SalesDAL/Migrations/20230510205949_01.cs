using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesDAL.Migrations
{
    /// <inheritdoc />
    public partial class _01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValue: "No description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "6394-8733-0737-3838", "Wilfred.OReilly20@gmail.com", "Mary" },
                    { 2, "4836418057660", "Obie.Glover@yahoo.com", "Lamont" },
                    { 3, "3416-253154-85526", "Gilbert.Carroll@yahoo.com", "Glen" },
                    { 4, "3020-129001-2143", "Hilton_Volkman@hotmail.com", "Annie" },
                    { 5, "6011-7704-8723-2003", "Elsa.Dietrich@hotmail.com", "Elta" },
                    { 6, "677195535304970424", "Noemie_Schmeler@hotmail.com", "Verla" },
                    { 7, "5477-3939-7419-1738", "Jayce_Bosco91@yahoo.com", "Johnathon" },
                    { 8, "6767-1858-8137-4394-359", "Lucinda_Torphy@yahoo.com", "Amy" },
                    { 9, "6455-6204-4017-4188-2441", "Andreanne_Wyman@hotmail.com", "Cristopher" },
                    { 10, "3621-766339-4623", "Gustave67@gmail.com", "Major" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Small Plastic Cheese", 766, 3 },
                    { 2, "Handcrafted Granite Chips", 1824, 1 },
                    { 3, "Handcrafted Wooden Chicken", 1337, 5 },
                    { 4, "Intelligent Wooden Shoes", 1884, 9 },
                    { 5, "Licensed Wooden Bike", 2973, 4 },
                    { 6, "Awesome Cotton Car", 388, 8 },
                    { 7, "Unbranded Soft Soap", 1291, 3 },
                    { 8, "Intelligent Steel Computer", 2109, 7 },
                    { 9, "Rustic Rubber Bacon", 2342, 3 },
                    { 10, "Sleek Rubber Towels", 448, 3 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { 1, "Wiza LLC" },
                    { 2, "Schmidt and Sons" },
                    { 3, "Beatty Group" },
                    { 4, "Grimes, Wiegand and Ratke" },
                    { 5, "Von Group" },
                    { 6, "Stiedemann, Kunze and Toy" },
                    { 7, "Ratke, Lakin and Harber" },
                    { 8, "Nader, Boehm and Rowe" },
                    { 9, "Schuster Group" },
                    { 10, "Gorczany, Auer and Streich" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { 1, 9, new DateTime(2022, 5, 17, 21, 38, 45, 326, DateTimeKind.Local).AddTicks(2068), 7, 2 },
                    { 2, 4, new DateTime(2022, 10, 7, 14, 12, 4, 830, DateTimeKind.Local).AddTicks(8560), 1, 5 },
                    { 3, 3, new DateTime(2022, 5, 11, 11, 21, 0, 761, DateTimeKind.Local).AddTicks(1544), 10, 10 },
                    { 4, 4, new DateTime(2022, 10, 24, 19, 55, 38, 596, DateTimeKind.Local).AddTicks(2228), 4, 3 },
                    { 5, 4, new DateTime(2022, 11, 22, 11, 35, 8, 194, DateTimeKind.Local).AddTicks(2090), 10, 3 },
                    { 6, 10, new DateTime(2023, 2, 10, 19, 37, 59, 168, DateTimeKind.Local).AddTicks(7500), 10, 7 },
                    { 7, 1, new DateTime(2022, 10, 4, 16, 24, 20, 431, DateTimeKind.Local).AddTicks(887), 9, 2 },
                    { 8, 9, new DateTime(2023, 2, 7, 18, 16, 55, 743, DateTimeKind.Local).AddTicks(4442), 9, 5 },
                    { 9, 1, new DateTime(2023, 5, 5, 4, 28, 40, 232, DateTimeKind.Local).AddTicks(7027), 7, 6 },
                    { 10, 8, new DateTime(2022, 10, 15, 10, 30, 53, 544, DateTimeKind.Local).AddTicks(4896), 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_StoreId",
                table: "Sales",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
