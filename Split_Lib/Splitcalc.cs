using System;

namespace Split_Lib;

    public class Splitcalc
    {
        public decimal SplitAmount(decimal totalAmount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
                throw new ArgumentException("Number of people must be greater than zero.");

            return totalAmount / numberOfPeople;
        }

        public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            decimal totalMealCost = 0;
            foreach (var pair in mealCosts)
            {
                totalMealCost += pair.Value;
            }

            Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();
            foreach (var pair in mealCosts)
            {
                decimal tipAmount = (decimal)tipPercentage / 100 * pair.Value;
                decimal weightedAverage = tipAmount / totalMealCost;

                tipAmounts.Add(pair.Key, weightedAverage);
            }

            return tipAmounts;
        }

        public decimal TipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
        {
            if (numberOfPatrons <= 0)
                throw new ArgumentException("Number of patrons must be greater than zero.");

            decimal totalTip = price * ((decimal)tipPercentage / 100);
            return totalTip / numberOfPatrons;
        }
    }
