using Microsoft.EntityFrameworkCore.Migrations;

namespace Example.Migrations
{
    public partial class CambiarDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "Id", "Ciudad", "Email", "Nombre" },
                values: new object[,]
                {
                    { 10000, "WirriLandia", "wirri@gmail.com", "Wirri Girl" },
                    { 2000, "AntoineLandia", "antoine@gmail.com", "Antoine" },
                    { 3000, "FrancoLandia", "francisco@gmail.com", "Francisco" },
                    { 4000, "PierreLandia", "pierre@gmail.com", "Pierre" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "Id", "Ciudad", "Email", "Nombre" },
                values: new object[] { 1000, "WirriLandia", "wirri@gmail.com", "Wirri Girl" });
        }
    }
}
