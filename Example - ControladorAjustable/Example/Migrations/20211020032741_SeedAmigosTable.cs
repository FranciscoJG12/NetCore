using Microsoft.EntityFrameworkCore.Migrations;

namespace Example.Migrations
{
    public partial class SeedAmigosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "Id", "Ciudad", "Email", "Nombre" },
                values: new object[] { 1000, "WirriLandia", "wirri@gmail.com", "Wirri Girl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 1000);
        }
    }
}
