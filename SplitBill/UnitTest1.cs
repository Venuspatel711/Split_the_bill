using Split_Lib; 

namespace SplitBill
{
    [TestClass]
    public class Splitcalc
    {
        [TestMethod]
        public void SplitAmount_WhenAmountIs100AndNumberOfPeopleIs5_ShouldReturn20()
        {
          
            Split_Lib.Splitcalc calculator = new Split_Lib.Splitcalc();

           
            decimal result = calculator.SplitAmount(100, 5);

            
            Assert.AreEqual(20, result);
        }
       [TestMethod]
        public void SplitAmount_WhenAmountIs50AndNumberOfPeopleIs2_ShouldReturn25()
        {
           
            
            Split_Lib.Splitcalc  calculator = new Split_Lib.Splitcalc();

            
            decimal result = calculator.SplitAmount(50, 2);

           
            Assert.AreEqual(25, result);
        }
    }
}
