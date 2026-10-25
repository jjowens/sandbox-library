using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SandboxLibrary.enums.original;

namespace SandboxTests.EnumTests
{
    [TestClass]
    public class CarModelEnumTests
    {
        [TestMethod]
        public void GetCarModelsAsSnakeCase()
        {
            Assert.AreEqual("redcar", CarModels.RedCar.ToSnakeCase());
            Assert.AreEqual("blue-car-with-white-walled-wheels", CarModels.BlueCarWithWhiteWalledWheels.ToSnakeCase());
            Assert.AreEqual("slow-car", CarModels.SlowCar.ToSnakeCase());
            Assert.AreEqual("fast-car", CarModels.FastCar.ToSnakeCase());
            Assert.AreEqual("brand-new-car", CarModels.BrandNewCar.ToSnakeCase());
        }

        [TestMethod]
        public void GetCarModelsAsUnderscoreCase()
        {
            Assert.AreEqual("redcar", CarModels.RedCar.ToUnderscoreCase());
            Assert.AreEqual("blue_car_with_white_walled_wheels", CarModels.BlueCarWithWhiteWalledWheels.ToUnderscoreCase());
            Assert.AreEqual("slow_car", CarModels.SlowCar.ToUnderscoreCase());
            Assert.AreEqual("fast_car", CarModels.FastCar.ToUnderscoreCase());
            Assert.AreEqual("brand_new_car", CarModels.BrandNewCar.ToUnderscoreCase());
        }


        [TestMethod]
        public void GetCarModelsAsCamelCase()
        {
            Assert.AreEqual("redcar", CarModels.RedCar.ToCamelCase());
            Assert.AreEqual("blueCarWithWhiteWalledWheels", CarModels.BlueCarWithWhiteWalledWheels.ToCamelCase());
            Assert.AreEqual("slowCar", CarModels.SlowCar.ToCamelCase());
            Assert.AreEqual("fastCar", CarModels.FastCar.ToCamelCase());
            Assert.AreEqual("brandNewCar", CarModels.BrandNewCar.ToCamelCase());
        }

        [TestMethod]
        public void GetCarModelsAsTitleCase()
        {
            Assert.AreNotEqual("RedCar", CarModels.RedCar.ToTitleCase());
            Assert.AreEqual("BlueCarWithWhiteWalledWheels", CarModels.BlueCarWithWhiteWalledWheels.ToTitleCase());
            Assert.AreEqual("SlowCar", CarModels.SlowCar.ToTitleCase());
            Assert.AreEqual("FastCar", CarModels.FastCar.ToTitleCase());
            Assert.AreEqual("BrandNewCar", CarModels.BrandNewCar.ToTitleCase());
        }
    }
}
