using Microsoft.VisualStudio.TestTools.UnitTesting;
using Split_Lib; // Assuming Split_Lib is the namespace of your TipCalculator class

namespace SplitBill // Remove the semicolon here
{
    [TestClass]
    public class SplitCalculatorTests
    {
        [TestMethod]
        public void SplitAmount_EqualSplit_ShouldReturnCorrectAmount()
        {
            spl calculator = new TipCalculator();
            decimal totalAmount = 100.00m;
            int numberOfPeople = 5;
            decimal expectedSplitAmount = 20.00m;

            decimal actualSplitAmount = calculator.SplitAmount(totalAmount, numberOfPeople);

            Assert.AreEqual(expectedSplitAmount, actualSplitAmount);
        }

        [TestMethod]
        public void CalculateTip_EqualSplit_ShouldReturnCorrectAmounts()
        {
            TipCalculator calculator = new TipCalculator();
            var mealCosts = new Dictionary<string, decimal>
            {
                { "Alice", 25.50m },
                { "Bob", 30.00m },
                { "Charlie", 22.75m }
            };
            float tipPercentage = 15;
            var expectedTipAmounts = new Dictionary<string, decimal>
            {
                { "Alice", 2.70m },
                { "Bob", 3.15m },
                { "Charlie", 2.38m }
            };

            var actualTipAmounts = calculator.CalculateTip(mealCosts, tipPercentage);

            CollectionAssert.AreEqual(expectedTipAmounts, actualTipAmounts);
        }

        [TestMethod]
        public void TipPerPerson_EqualSplit_ShouldReturnCorrectAmount()
        {
            TipCalculator calculator = new TipCalculator();
            decimal price = 100.00m;
            int numberOfPatrons = 5;
            float tipPercentage = 15;
            decimal expectedTipPerPerson = 3.00m;

            decimal actualTipPerPerson = calculator.TipPerPerson(price, numberOfPatrons, tipPercentage);

            Assert.AreEqual(expectedTipPerPerson, actualTipPerPerson);
        }
    }
}
