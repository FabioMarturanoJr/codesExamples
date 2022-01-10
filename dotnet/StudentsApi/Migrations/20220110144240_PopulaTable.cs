using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsApi.Migrations
{
    public partial class PopulaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Email", "Name" },
                values: new object[] { 1, 27, "fabio.marturano@email.com", "Fabio Marturano" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Email", "Name" },
                values: new object[] { 2, 29, "bruna.marturano@email.com", "Bruna Marturano" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
