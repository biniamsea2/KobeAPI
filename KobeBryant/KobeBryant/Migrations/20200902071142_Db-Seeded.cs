using Microsoft.EntityFrameworkCore.Migrations;

namespace KobeBryant.Migrations
{
    public partial class DbSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true),
                    Record = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "ID", "Name", "Record", "Team" },
                values: new object[,]
                {
                    { 1, "Kobe Bryant", "Most Seasons played for a single NBA Franchise: 20 (tied with Dirk Nowitzki)", "Los Angeles Lakers" },
                    { 21, "Kobe Bryant", "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)", "Los Angeles Lakers" },
                    { 20, "Kobe Bryant", "Oldest player to score 60+ points, one game: (37 years, 234 days)", "Los Angeles Lakers" },
                    { 19, "Kobe Bryant", "Only player in NBA history to score at least 600 points in the postseason for three consecutive years. 633(2008), 695(2009), 671(2010)", "Los Angeles Lakers" },
                    { 18, "Kobe Bryant", "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)", "Los Angeles Lakers" },
                    { 17, "Kobe Bryant", "Youngest player to start an All-Star game: (19 years, 169 days)", "Los Angeles Lakers" },
                    { 16, "Kobe Bryant", "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)", "Los Angeles Lakers" },
                    { 15, "Kobe Bryant", "Youngest player to start a game: (18 years, 158 days)", "Los Angeles Lakers" },
                    { 14, "Kobe Bryant", "Youngest player to be named to the NBA All-Rookie Team: (1996–97)", "Los Angeles Lakers" },
                    { 13, "Kobe Bryant", "Youngest player to be named to the NBA All-Defensive Team: (1999–2000 season)", "Los Angeles Lakers" },
                    { 22, "Kobe Bryant", "Most total playoff CP with 3800", "Los Angeles Lakers" },
                    { 12, "Kobe Bryant", "Youngest player to be named to the NBA All-Rookie Team: (1996–97)", "Los Angeles Lakers" },
                    { 10, "Kobe Bryant", "Youngest player to score 32,000 points: (36 years, 87 days). Surpassed Karl Malone, the previous holder of the record", "Los Angeles Lakers" },
                    { 9, "Kobe Bryant", "Highest Score against rest of teams in the league above 40 (share with Bob Pettit). Surpassed Hakeem Olajuwon, the previous holder of the record", "Los Angeles Lakers" },
                    { 8, "Kobe Bryant", "Most points scored in one arena, career: 16,161 (as of April 14, 2016, at Staples Center, Los Angeles)", "Los Angeles Lakers" },
                    { 7, "Kobe Bryant", "Most free throws made, four-game playoff series: 51 (second round vs. Sacramento Kings, 2001)", "Los Angeles Lakers" },
                    { 6, "Kobe Bryant", "Most All-Defensive First Team honors won, career: 9 (tied with Michael Jordan, Gary Payton, and Kevin Garnett)", "Los Angeles Lakers" },
                    { 5, "Kobe Bryant", "Most All-NBA First Team honors won, career: 11 (tied with Karl Malone and LeBron James)", "Los Angeles Lakers" },
                    { 4, "Kobe Bryant", "Most All-NBA Total Selections won, career: 15 (tied with Kareem Abdul-Jabbar and Tim Duncan)", "Los Angeles Lakers" },
                    { 3, "Kobe Bryant", "Most offensive rebounds in an All-Star Game: 10", "Los Angeles Lakers" },
                    { 2, "Kobe Bryant", "Most All-Star Game MVP awards won, career: 4 (tied with Bob Pettit)", "Los Angeles Lakers" },
                    { 11, "Kobe Bryant", "Youngest player to score 33,000 points: (37 years, 138 days). Surpassed Kareem Abdul - Jabbar,the previous holder of the record", "Los Angeles Lakers" },
                    { 23, "Kobe Bryant", "Highest CPPG with 20 cppg", "Los Angeles Lakers" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
