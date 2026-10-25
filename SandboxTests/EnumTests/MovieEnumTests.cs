using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SandboxLibrary.enums.original;

namespace SandboxTests.EnumTests
{
    [TestClass]
    public class MovieEnumTests
    {
        [TestMethod]
        public void GetMovieTitlesAsSnakeCase()
        {
            Assert.AreEqual("the-shining", MovieTitles.TheShining.ToSnakeCase());
            Assert.AreEqual("an-american-werewolf-in-london", MovieTitles.AnAmericanWerewolfInLondon.ToSnakeCase());
            Assert.AreEqual("scream", MovieTitles.Scream.ToSnakeCase());
            Assert.AreEqual("salems-lot", MovieTitles.SalemsLot.ToSnakeCase());
            Assert.AreEqual("the-thing", MovieTitles.TheThing.ToSnakeCase());
        }

        [TestMethod]
        public void GetMovieTitlesAsUnderscoreCase()
        {
            Assert.AreEqual("the_shining", MovieTitles.TheShining.ToUnderscoreCase());
            Assert.AreEqual("an_american_werewolf_in_london", MovieTitles.AnAmericanWerewolfInLondon.ToUnderscoreCase());
            Assert.AreEqual("scream", MovieTitles.Scream.ToUnderscoreCase());
            Assert.AreEqual("salems_lot", MovieTitles.SalemsLot.ToUnderscoreCase());
            Assert.AreEqual("the_thing", MovieTitles.TheThing.ToUnderscoreCase());
        }


        [TestMethod]
        public void GetMovieTitlesAsCamelCase()
        {
            Assert.AreEqual("theShining", MovieTitles.TheShining.ToCamelCase());
            Assert.AreEqual("anAmericanWerewolfInLondon", MovieTitles.AnAmericanWerewolfInLondon.ToCamelCase());
            Assert.AreEqual("scream", MovieTitles.Scream.ToCamelCase());
            Assert.AreEqual("salemsLot", MovieTitles.SalemsLot.ToCamelCase());
            Assert.AreEqual("theThing", MovieTitles.TheThing.ToCamelCase());
        }


        [TestMethod]
        public void GetMovieTitlesAsTitleCase()
        {
            Assert.AreEqual("TheShining", MovieTitles.TheShining.ToTitleCase());
            Assert.AreEqual("AnAmericanWerewolfInLondon", MovieTitles.AnAmericanWerewolfInLondon.ToTitleCase());
            Assert.AreEqual("Scream", MovieTitles.Scream.ToTitleCase());
            Assert.AreEqual("SalemsLot", MovieTitles.SalemsLot.ToTitleCase());
            Assert.AreEqual("TheThing", MovieTitles.TheThing.ToTitleCase());
        }
    }
}
