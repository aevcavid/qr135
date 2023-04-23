using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersRole.Migrations
{
    public partial class permission_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Key", "Name" },
                values: new object[,]
                {
                    { 1, "add", "add" },
                    { 2, "report", "hesabat" },
                    { 3, "view", "view" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
