using System;

namespace Split_Lib;

    public class Splitcalc
    {
      public decimal SplitAmount(decimal amount, int numberOfPeople)
{
    if (numberOfPeople <= 0)
    {
        throw new ArgumentException("Number of people must be greater than zero.");
    }

    return amount / numberOfPeople;
}


    }
