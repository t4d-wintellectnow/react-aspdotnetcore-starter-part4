using Microsoft.EntityFrameworkCore.Migrations;

namespace WidgetsApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Widgets",
                columns: new[] { "Id", "Color", "Name", "Quantity" },
                values: new object[] { 1, "red", "Red Widget", 23 });

            migrationBuilder.InsertData(
                table: "Widgets",
                columns: new[] { "Id", "Color", "Name", "Quantity" },
                values: new object[] { 2, "blue", "Blue Widget", 31 });

            migrationBuilder.InsertData(
                table: "Widgets",
                columns: new[] { "Id", "Color", "Name", "Quantity" },
                values: new object[] { 3, "yellow", "Yellow Widget", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Widgets");
        }
    }
}
