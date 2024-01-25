using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommandBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "Id", "Autor", "Titulo" },
                values: new object[] { 2, "Dan Wells", "The Maze Runner" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
