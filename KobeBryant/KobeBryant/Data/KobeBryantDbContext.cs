using KobeBryant.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeBryant.Data
{
    public class KobeBryantDbContext : DbContext
    {
        public KobeBryantDbContext(DbContextOptions<KobeBryantDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kobe>().HasData(
                new Kobe
                {
                    ID = 1,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most Seasons played for a single NBA Franchise: 20 (tied with Dirk Nowitzki)",
                },
                new Kobe
                {
                    ID = 2,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most All-Star Game MVP awards won, career: 4 (tied with Bob Pettit)",
                },
                new Kobe
                {
                    ID = 3,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most offensive rebounds in an All-Star Game: 10",
                },
                new Kobe
                {
                    ID = 4,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most All-NBA Total Selections won, career: 15 (tied with Kareem Abdul-Jabbar and Tim Duncan)",
                },
                new Kobe
                {
                    ID = 5,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most All-NBA First Team honors won, career: 11 (tied with Karl Malone and LeBron James)",
                },
                new Kobe
                {
                    ID = 6,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most All-Defensive First Team honors won, career: 9 (tied with Michael Jordan, Gary Payton, and Kevin Garnett)",
                },
                new Kobe
                {
                    ID = 7,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most free throws made, four-game playoff series: 51 (second round vs. Sacramento Kings, 2001)",
                },
                new Kobe
                {
                    ID = 8,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most points scored in one arena, career: 16,161 (as of April 14, 2016, at Staples Center, Los Angeles)",
                },
                new Kobe
                {
                    ID = 9,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Highest Score against rest of teams in the league above 40 (share with Bob Pettit). Surpassed Hakeem Olajuwon, the previous holder of the record",
                },
                new Kobe
                {
                    ID = 10,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to score 32,000 points: (36 years, 87 days). Surpassed Karl Malone, the previous holder of the record",
                },
                new Kobe
                {
                    ID = 11,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to score 33,000 points: (37 years, 138 days). Surpassed Kareem Abdul - Jabbar,the previous holder of the record",
                },
                new Kobe
                {
                    ID = 12,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to be named to the NBA All-Rookie Team: (1996–97)",
                },
                new Kobe
                {
                    ID = 13,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to be named to the NBA All-Defensive Team: (1999–2000 season)",
                },
                new Kobe
                {
                    ID = 14,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to be named to the NBA All-Rookie Team: (1996–97)",
                },
                new Kobe
                {
                    ID = 15,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to start a game: (18 years, 158 days)",
                },
                new Kobe
                {
                    ID = 16,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)",
                },
                new Kobe
                {
                    ID = 17,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to start an All-Star game: (19 years, 169 days)",
                },
                new Kobe
                {
                    ID = 18,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)",
                },
                new Kobe
                {
                    ID = 19,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Only player in NBA history to score at least 600 points in the postseason for three consecutive years. 633(2008), 695(2009), 671(2010)",
                },
                new Kobe
                {
                    ID = 20,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Oldest player to score 60+ points, one game: (37 years, 234 days)",
                },
                new Kobe
                {
                    ID = 21,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)",
                },
                new Kobe
                {
                    ID = 22,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Most total playoff CP with 3800",
                },
                new Kobe
                {
                    ID = 23,
                    Name = "Kobe Bryant",
                    Team = "Los Angeles Lakers",
                    Record = "Highest CPPG with 20 cppg",
                }
            );
        }
        public DbSet<Kobe> Records { get; set; }
    }
}
