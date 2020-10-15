using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Review" },
                values: new object[,]
                {
                    { 1, "Early Career", "1963", "PleasePleaseMe.jpg", "Please Please Me", null },
                    { 2, "Early Career", "1964", "MeettheBeatles.jpg", "Meet the Beatles", null },
                    { 3, "Early Career", "1964", "HardDaysNight.jpg", "Hard Day's Night", null },
                    { 4, "Early Career", "1964", "BeatlesforSale.jpg", "Beatles for Sale", null },
                    { 5, "Mid-Career", "1965", "Help!.jpg", "Help!", null },
                    { 6, "Mid-Career", "1965", "RubberSoul.jpg", "Rubber Soul", null },
                    { 7, "Mid-Career", "1966", "Revolver.jpg", "Revolver", null },
                    { 8, "Late Career", "1967", "SgtPepper.jpg", "Sgt. Pepper's Lonely Hearts Club Band", null },
                    { 9, "Late Career", "1967", "MagicalMysteryTour.jpg", "Magical Mystery Tour", null },
                    { 10, "Late Career", "1968", "WhiteAlbum.jpg", "White Album", null },
                    { 11, "Late Career", "1969", "YellowSubmarine.jpg", "Yellow Submarine", null },
                    { 12, "Late Career", "1969", "AbbeyRoad.jpg", "Abbey Road", null },
                    { 13, "Late Career", "1970", "LetItBe.jpg", "Let It Be", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
