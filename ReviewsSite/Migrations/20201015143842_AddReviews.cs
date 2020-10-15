using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "Albums");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    ReviewerName = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<string>(nullable: true),
                    AlbumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[,]
                {
                    { 1, 7, "This album is good.", 5, "10/15/2020", "Paul McCartney" },
                    { 2, 7, "This album is really good.", 5, "10/15/2020", "John Lennon" },
                    { 3, 7, "This album is great.", 5, "10/15/2020", "George Harrison" },
                    { 4, 7, "This album is really great.", 5, "10/15/2020", "Ringo Starr" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AlbumId",
                table: "Reviews",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
