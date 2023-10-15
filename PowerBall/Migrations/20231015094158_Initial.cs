using Microsoft.EntityFrameworkCore.Migrations;

namespace PowerBall.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Lottary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    PowerballNumbers = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lottary", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { "L1", "Lottery Genre 1" },
                    { "L2", "Lottery Genre 2" }
                });

            migrationBuilder.InsertData(
                table: "Lottary",
                columns: new[] { "Id", "Age", "FullName", "Gender", "Location", "PowerballNumbers" },
                values: new object[,]
                {
                    { 1, 30, "John Doe", "Male", "New York", "1 2 3 4 5 PB: 6" },
                    { 2, 28, "Jane Smith", "Female", "Los Angeles", "7 8 9 10 11 PB: 12" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Lottary");
        }
    }
}
