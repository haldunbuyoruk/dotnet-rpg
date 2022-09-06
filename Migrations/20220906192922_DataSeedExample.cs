using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_rpg.Migrations
{
    public partial class DataSeedExample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defense", "HitPoints", "Intelligence", "Name", "Strength" },
                values: new object[] { 1, 1, 10, 100, 10, "Frodo", 15 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defense", "HitPoints", "Intelligence", "Name", "Strength" },
                values: new object[] { 2, 2, 5, 100, 20, "Raistlin", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
