using System;
using Xunit;
using KobeBryant.Data;
using KobeBryant.Models;
using KobeBryant.Models.Service;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void GetRecordInfo()
        {
            Kobe kb = new Kobe();
            kb.Name = "Kobe Bryant";
            kb.Team = "Los Angeles Lakers";
            kb.Record = "Most Dunks in a game (10)";

            Assert.Equal("Kobe Bryant", kb.Name);
            Assert.Equal("Los Angeles Lakers", kb.Team);
            Assert.Equal("Most Dunks in a game (10)", kb.Record);
        }
    }
}