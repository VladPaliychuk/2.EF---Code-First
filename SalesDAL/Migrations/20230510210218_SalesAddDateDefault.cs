using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesDAL.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "670694539254285941", "Demond.Sawayn@hotmail.com", "Rylan" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3498-458407-41795", "Marcia15@gmail.com", "Fanny" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5512-4525-6886-0764", "Roderick69@yahoo.com", "Janelle" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "4376-3320-5613-5028", "Kaley.Rohan54@gmail.com", "Maverick" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6771-8971-5043-3004", "Domenico.Cummings95@yahoo.com", "Rosalinda" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "4258-2643-1733-8286", "Floy_Homenick16@yahoo.com", "Melisa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3486-179146-41982", "Russel_Veum@yahoo.com", "Vanessa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "63047291288950742", "Hope47@hotmail.com", "Ramon" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3487-258173-13938", "Sydney_MacGyver@yahoo.com", "Anibal" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6398-9961-4820-3850", "Kole.Berge@yahoo.com", "Lesly" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Incredible Cotton Towels", 1911, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Incredible Granite Chair", 1330, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Sleek Plastic Gloves", 542, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Ergonomic Concrete Mouse", 1209, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Rustic Wooden Cheese", 1203, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Licensed Fresh Soap", 1198, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Awesome Steel Bike", 1379, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Sleek Concrete Chips", 1973, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Unbranded Soft Sausages", 517, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Refined Steel Mouse", 1137, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 1,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 1, new DateTime(2022, 8, 19, 5, 40, 38, 254, DateTimeKind.Local).AddTicks(2482), 8 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 8, new DateTime(2023, 2, 7, 21, 56, 44, 832, DateTimeKind.Local).AddTicks(4751), 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 3,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 2, new DateTime(2022, 12, 29, 6, 32, 25, 435, DateTimeKind.Local).AddTicks(7096), 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 4,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 3, new DateTime(2022, 8, 27, 0, 50, 10, 65, DateTimeKind.Local).AddTicks(1390), 4, 6 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 5, new DateTime(2022, 11, 27, 5, 11, 20, 788, DateTimeKind.Local).AddTicks(1546), 10, 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 1, new DateTime(2022, 7, 6, 19, 29, 30, 957, DateTimeKind.Local).AddTicks(3541), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "Date", "ProductId", "StoreId" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 19, 19, 99, DateTimeKind.Local).AddTicks(6034), 4, 10 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "Date", "ProductId", "StoreId" },
                values: new object[] { new DateTime(2023, 3, 28, 16, 35, 23, 918, DateTimeKind.Local).AddTicks(3083), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 2, new DateTime(2023, 2, 26, 12, 56, 51, 900, DateTimeKind.Local).AddTicks(6946), 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 7, new DateTime(2023, 3, 30, 2, 22, 23, 758, DateTimeKind.Local).AddTicks(5781), 7, 4 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Streich LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Willms - Reichert");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Stamm, Boyle and Konopelski");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Lockman Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Willms - Satterfield");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 6,
                column: "Name",
                value: "Bosco and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 7,
                column: "Name",
                value: "Lueilwitz, Zboncak and Klocko");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 8,
                column: "Name",
                value: "Cummings Inc");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 9,
                column: "Name",
                value: "Daugherty, Satterfield and Feil");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 10,
                column: "Name",
                value: "Kuvalis LLC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 7, new DateTime(2023, 5, 4, 19, 5, 12, 722, DateTimeKind.Local).AddTicks(3098), 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 10, new DateTime(2022, 11, 29, 12, 30, 31, 929, DateTimeKind.Local).AddTicks(3702), 1 });

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
                columns: new[] { "Date", "ProductId", "StoreId" },
                values: new object[] { new DateTime(2022, 7, 4, 12, 52, 50, 709, DateTimeKind.Local).AddTicks(1762), 10, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "Date", "ProductId", "StoreId" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 9, 40, 680, DateTimeKind.Local).AddTicks(2414), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 3, new DateTime(2023, 2, 18, 10, 36, 18, 371, DateTimeKind.Local).AddTicks(6564), 9 });

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
    }
}
