using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SandboxLibrary.enums.batch1;
using System.ComponentModel;
using SandboxLibrary.enums.batch1.components;

namespace SandboxTests
{
    [TestClass]
    public class CartoonCharactersTests
    {
        [TestMethod]
        public void GetSnakeCase()
        {
            Assert.AreEqual("bugs-bunny", CartoonCharacters.BugsBunny.GetSnakeCase());
            Assert.AreEqual("porky-pig", CartoonCharacters.PorkyPig.GetSnakeCase());
            Assert.AreEqual("daffy-duck", CartoonCharacters.DaffyDuck.GetSnakeCase());
            Assert.AreEqual("marvin-the-martian", CartoonCharacters.MarvinTheMartian.GetSnakeCase());
        }

        [TestMethod]
        public void GetUnscoreCase()
        {
            Assert.AreEqual("bugs_bunny", CartoonCharacters.BugsBunny.GetUnderscore());
            Assert.AreEqual("porky_pig", CartoonCharacters.PorkyPig.GetUnderscore());
            Assert.AreEqual("daffy_duck", CartoonCharacters.DaffyDuck.GetUnderscore());
            Assert.AreEqual("marvin_the_martian", CartoonCharacters.MarvinTheMartian.GetUnderscore());
        }

    }
}
