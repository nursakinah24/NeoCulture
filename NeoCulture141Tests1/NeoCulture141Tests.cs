using NUnit.Framework;

namespace NeoCulture141.Tests
{
    [TestFixture]
    public class GroceryTests
    {
        [Test]
        public void TestSugarTotalPriceCalculation()
        {
            // Arrange
            var sugar = new Sugar();
            sugar.sugarkg = 2; // Set the desired amount of sugar

            // Act
            var totalPrice = sugar.HitungSugar1();

            // Assert
            Assert.AreEqual(24000, totalPrice); // Assuming the price per kg is 12000
        }

        [Test]
        public void TestRiceTotalPriceCalculation()
        {
            // Arrange
            var rice = new Rice();
            rice.ricekg = 3; // Set the desired amount of rice

            // Act
            var totalPrice = rice.HitungRice1();

            // Assert
            Assert.AreEqual(34500, totalPrice); // Assuming the price per kg is 11500
        }

        [Test]
        public void TestCookingOilTotalPriceCalculation()
        {
            // Arrange
            var cookingOil = new CookingOil();
            cookingOil.oilLtr = 1.5; // Set the desired amount of cooking oil

            // Act
            var totalPrice = cookingOil.HitungOil1();

            // Assert
            Assert.AreEqual(21750, totalPrice); // Assuming the price per liter is 14500
        }

        [Test]
        public void TestEggsTotalPriceCalculation()
        {
            // Arrange
            var eggs = new Eggs();
            eggs.eggkg = 1; // Set the desired amount of eggs

            // Act
            var totalPrice = eggs.HitungEgg1();

            // Assert
            Assert.AreEqual(19500, totalPrice); // Assuming the price per kg is 19500
        }
    }
}
