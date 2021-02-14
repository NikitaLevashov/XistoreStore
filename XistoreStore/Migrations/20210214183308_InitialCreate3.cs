using Microsoft.EntityFrameworkCore.Migrations;

namespace XistoreStore.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "POCO", "6.67 AMOLED(1080x2400) / 2 SIM / Android 10.0 / 2840 МГц(Ядер: 8) / 6Gb / 128Gb / 64 Мп + 12 Мп + 5 Мп + 5 Мп / 4 700 мАч / пурпурный", "Poco F2 Pro", 1699m },
                    { 2, "POCO", "6.67 IPS(1080x2400) / 2 SIM / Android 10.0 / 2300 МГц(Ядер: 8) / 6Gb / 128Gb / 64 Мп + 13 Мп + 2 Мп + 2 Мп / 5 160 мАч / чёрный", "Poco X3", 999m },
                    { 3, "Redmi Note", "6.67 IPS (1080x2400) /2 SIM / Android 10 с оболочкой MIUI 11 / 2300 МГц (Ядер: 8) / 6Gb /64Gb / 64 Мп + 8 Мп + 2 Мп + 5 Мп / 5 020 мАч / серый", "Redmi Note 9 Pro", 729m },
                    { 4, "Redmi Note", "6.67 (1080x2400) /2 SIM / 2300 МГц (Ядер: 8) / 4Gb /64Gb / 48 Мп + 8 Мп + 5 Мп + 2 Мп / 5 020 мАч / Синяя Мгла", "Redmi Note 9S", 649m },
                    { 5, "Redmi Note", "6.53 IPS(1080x2340) / 2 SIM / Android 10 с оболочкой MIUI 11 / 2000 МГц(Ядер: 8) / 3Gb / 64Gb / 48 Мп + 8 Мп + 2 Мп + 2 Мп / 5 020 мАч / серый", "Redmi Note 9", 559m },
                    { 6, "Redmi Note", "6.53 IPS (1080x2340) /2 SIM / Android 9 Pie / 2050 МГц (Ядер: 8) / 6Gb /64Gb / 64 Мп + 8 Мп + 2 Мп + 2 Мп / 4 500 мАч / зелёный", "Redmi Note 8 Pro", 649m },
                    { 7, "Redmi Note", "6.53 IPS(1080x2340) / 2 SIM / Android 10.0 / (Ядер: 8) / 4Gb / 128Gb / 48 Мп + 2 Мп + 2 Мп / 5 000 мАч / чёрный", "Redmi Note 9T", 799m },
                    { 8, "Redmi", "6.53 IPS(1080x2340) / 2 SIM / Android 10 с оболочкой MIUI 11 / 2000 МГц(Ядер: 8) / 3Gb / 32Gb / 13 Мп + 8 Мп + 2 Мп + 5 Мп / 5 020 мАч / зелёный", "Redmi 9", 449m },
                    { 9, "Redmi", "6.53 IPS(720x1600) / 2 SIM / Android 10.0 / 2000 МГц(Ядер: 8) / 2Gb / 32Gb / 13 Мп / 5 000 мАч / синийй", "Redmi 9A", 299m },
                    { 10, "Redmi", "6.53 IPS(720x1600) / 2 SIM / Android 10 с оболочкой MIUI 12 / 2300 МГц(Ядер: 8) / 3Gb / 64Gb / 13 Мп + 2 Мп + 2 Мп / 5 000 мАч / синий", "Redmi 9C", 399m },
                    { 11, "Mi", "6.67 IPS (1080x2400) /2 SIM / Android 10.0 / 2840 МГц (Ядер: 8) / 8Gb /128Gb / 64 Мп + 13 Мп + 5 Мп / 5 000 мАч / чёрный", "Xiaomi Mi10T", 1499m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);
        }
    }
}
