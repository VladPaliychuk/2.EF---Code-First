using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesDAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductAddColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5408-1261-3734-5872", "Ruth1@gmail.com", "Shany" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5018372986071820655", "Ruby.Anderson76@gmail.com", "Carlie" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6771-8918-5946-5912", "Wilhelm4@yahoo.com", "Sterling" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3760-383430-64347", "Kamron_Zieme93@gmail.com", "Lincoln" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5479-2837-6770-9077", "Thalia65@gmail.com", "Karen" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3529-6659-5342-5739", "Mason_Paucek90@gmail.com", "Donny" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "4925828234793", "Antonia46@hotmail.com", "Ora" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3528-9834-0586-8062", "Felipa_Treutel10@gmail.com", "Diego" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6373-5407-4468-4235", "Darrin_West@yahoo.com", "Ned" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-7113-1686-6849", "Kevon10@yahoo.com", "Keira" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Generic Rubber Fish", 2996, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Licensed Granite Chair", 1677, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Gorgeous Wooden Table", 1519, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Unbranded Soft Tuna", 375, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Tasty Metal Bacon", 820, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Sleek Granite Pizza", 1402, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Licensed Fresh Car", 1720, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Handmade Fresh Fish", 1161, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Practical Granite Car", 2892, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Tasty Concrete Bacon", 2313, 6 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 1,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 7, new DateTime(2023, 5, 4, 19, 5, 12, 722, DateTimeKind.Local).AddTicks(3098), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 10, new DateTime(2022, 11, 29, 12, 30, 31, 929, DateTimeKind.Local).AddTicks(3702), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 3,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 9, new DateTime(2022, 9, 27, 12, 18, 4, 757, DateTimeKind.Local).AddTicks(8535), 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 4,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 6, new DateTime(2022, 12, 4, 13, 49, 23, 423, DateTimeKind.Local).AddTicks(8181), 10, 10 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateTime(2022, 7, 20, 11, 23, 33, 972, DateTimeKind.Local).AddTicks(1668), 1, 10 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 3, new DateTime(2022, 11, 15, 23, 6, 8, 593, DateTimeKind.Local).AddTicks(1279), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 4, new DateTime(2022, 7, 4, 12, 52, 50, 709, DateTimeKind.Local).AddTicks(1762), 10, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 7, new DateTime(2023, 2, 27, 0, 9, 40, 680, DateTimeKind.Local).AddTicks(2414), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 3, new DateTime(2023, 2, 18, 10, 36, 18, 371, DateTimeKind.Local).AddTicks(6564), 2, 9 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 3, new DateTime(2022, 6, 3, 1, 28, 43, 63, DateTimeKind.Local).AddTicks(3478), 1, 7 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Stark and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Bosco LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Kreiger, Glover and Mills");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Kulas Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Christiansen, Vandervort and Kunze");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 6,
                column: "Name",
                value: "Ritchie LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 7,
                column: "Name",
                value: "Hammes LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 8,
                column: "Name",
                value: "Leannon, Boyer and O'Kon");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 9,
                column: "Name",
                value: "Wilkinson and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 10,
                column: "Name",
                value: "Wilderman - Ward");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6394-8733-0737-3838", "Wilfred.OReilly20@gmail.com", "Mary" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "4836418057660", "Obie.Glover@yahoo.com", "Lamont" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3416-253154-85526", "Gilbert.Carroll@yahoo.com", "Glen" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3020-129001-2143", "Hilton_Volkman@hotmail.com", "Annie" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6011-7704-8723-2003", "Elsa.Dietrich@hotmail.com", "Elta" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "677195535304970424", "Noemie_Schmeler@hotmail.com", "Verla" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5477-3939-7419-1738", "Jayce_Bosco91@yahoo.com", "Johnathon" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-1858-8137-4394-359", "Lucinda_Torphy@yahoo.com", "Amy" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6455-6204-4017-4188-2441", "Andreanne_Wyman@hotmail.com", "Cristopher" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3621-766339-4623", "Gustave67@gmail.com", "Major" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Small Plastic Cheese", 766, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Handcrafted Granite Chips", 1824, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Handcrafted Wooden Chicken", 1337, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Intelligent Wooden Shoes", 1884, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Licensed Wooden Bike", 2973, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Awesome Cotton Car", 388, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Unbranded Soft Soap", 1291, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Intelligent Steel Computer", 2109, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Rustic Rubber Bacon", 2342, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Sleek Rubber Towels", 448, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 1,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 9, new DateTime(2022, 5, 17, 21, 38, 45, 326, DateTimeKind.Local).AddTicks(2068), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 4, new DateTime(2022, 10, 7, 14, 12, 4, 830, DateTimeKind.Local).AddTicks(8560), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 3,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 3, new DateTime(2022, 5, 11, 11, 21, 0, 761, DateTimeKind.Local).AddTicks(1544), 10 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 4,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 4, new DateTime(2022, 10, 24, 19, 55, 38, 596, DateTimeKind.Local).AddTicks(2228), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 4, new DateTime(2022, 11, 22, 11, 35, 8, 194, DateTimeKind.Local).AddTicks(2090), 10, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 10, new DateTime(2023, 2, 10, 19, 37, 59, 168, DateTimeKind.Local).AddTicks(7500), 10, 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 1, new DateTime(2022, 10, 4, 16, 24, 20, 431, DateTimeKind.Local).AddTicks(887), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 9, new DateTime(2023, 2, 7, 18, 16, 55, 743, DateTimeKind.Local).AddTicks(4442), 9, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 1, new DateTime(2023, 5, 5, 4, 28, 40, 232, DateTimeKind.Local).AddTicks(7027), 7, 6 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateTime(2022, 10, 15, 10, 30, 53, 544, DateTimeKind.Local).AddTicks(4896), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Wiza LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Schmidt and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Beatty Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Grimes, Wiegand and Ratke");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Von Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 6,
                column: "Name",
                value: "Stiedemann, Kunze and Toy");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 7,
                column: "Name",
                value: "Ratke, Lakin and Harber");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 8,
                column: "Name",
                value: "Nader, Boehm and Rowe");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 9,
                column: "Name",
                value: "Schuster Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 10,
                column: "Name",
                value: "Gorczany, Auer and Streich");
        }
    }
}
