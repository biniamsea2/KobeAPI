﻿// <auto-generated />
using KobeBryant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KobeBryant.Migrations
{
    [DbContext(typeof(KobeBryantDbContext))]
    [Migration("20200902071142_Db-Seeded")]
    partial class DbSeeded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KobeBryant.Models.Kobe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Record")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Kobe Bryant",
                            Record = "Most Seasons played for a single NBA Franchise: 20 (tied with Dirk Nowitzki)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Kobe Bryant",
                            Record = "Most All-Star Game MVP awards won, career: 4 (tied with Bob Pettit)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Kobe Bryant",
                            Record = "Most offensive rebounds in an All-Star Game: 10",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Kobe Bryant",
                            Record = "Most All-NBA Total Selections won, career: 15 (tied with Kareem Abdul-Jabbar and Tim Duncan)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Kobe Bryant",
                            Record = "Most All-NBA First Team honors won, career: 11 (tied with Karl Malone and LeBron James)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Kobe Bryant",
                            Record = "Most All-Defensive First Team honors won, career: 9 (tied with Michael Jordan, Gary Payton, and Kevin Garnett)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Kobe Bryant",
                            Record = "Most free throws made, four-game playoff series: 51 (second round vs. Sacramento Kings, 2001)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Kobe Bryant",
                            Record = "Most points scored in one arena, career: 16,161 (as of April 14, 2016, at Staples Center, Los Angeles)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 9,
                            Name = "Kobe Bryant",
                            Record = "Highest Score against rest of teams in the league above 40 (share with Bob Pettit). Surpassed Hakeem Olajuwon, the previous holder of the record",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 10,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to score 32,000 points: (36 years, 87 days). Surpassed Karl Malone, the previous holder of the record",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 11,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to score 33,000 points: (37 years, 138 days). Surpassed Kareem Abdul - Jabbar,the previous holder of the record",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 12,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to be named to the NBA All-Rookie Team: (1996–97)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 13,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to be named to the NBA All-Defensive Team: (1999–2000 season)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 14,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to be named to the NBA All-Rookie Team: (1996–97)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 15,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to start a game: (18 years, 158 days)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 16,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 17,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to start an All-Star game: (19 years, 169 days)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 18,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 19,
                            Name = "Kobe Bryant",
                            Record = "Only player in NBA history to score at least 600 points in the postseason for three consecutive years. 633(2008), 695(2009), 671(2010)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 20,
                            Name = "Kobe Bryant",
                            Record = "Oldest player to score 60+ points, one game: (37 years, 234 days)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 21,
                            Name = "Kobe Bryant",
                            Record = "Youngest player to win the NBA Slam Dunk Championship: (18 years, 169 days)",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 22,
                            Name = "Kobe Bryant",
                            Record = "Most total playoff CP with 3800",
                            Team = "Los Angeles Lakers"
                        },
                        new
                        {
                            ID = 23,
                            Name = "Kobe Bryant",
                            Record = "Highest CPPG with 20 cppg",
                            Team = "Los Angeles Lakers"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
