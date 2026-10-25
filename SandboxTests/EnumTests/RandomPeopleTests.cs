using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SandboxLibrary.enums.batch2.components;
using SandboxLibrary.enums.batch2;
using SandboxLibrary.enums.batch1.components;

namespace SandboxTests.EnumTests
{
    [TestClass]
    public class RandomPeopleTests
    {
        [TestMethod]
        public void AppendTextTest()
        {
            Assert.AreEqual("David has tea", RandomPeople.David.AppendText("has tea"));
            Assert.AreEqual("Julie is drinking matcha", RandomPeople.Julie.AppendText("is drinking matcha"));

        }

        [TestMethod]
        public void CartwheelsTests()
        {
            Assert.AreEqual("Julie the Fitness Instructor does some cartwheels", RandomPeople.Julie.GetAttribute<System.ComponentModel.DescriptionAttribute>().Cartwheels());
            Assert.AreEqual("Harry the multitasker does some cartwheels", RandomPeople.Harry.GetAttribute<System.ComponentModel.DescriptionAttribute>().Cartwheels());
        }

        [TestMethod]
        public void RandomComponentTests()
        {
            Assert.AreEqual("has been doing IT for 5 years", RandomPeople.David.GetAttribute<RandomPeopleComponent>().GetRandomComponent());

        }
    }
}
