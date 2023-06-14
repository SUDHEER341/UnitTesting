using UnitTesting;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Logical_Programs objLogicalPrograms;

        [TestInitialize]
        public void SetUp()
        {
            objLogicalPrograms = new Logical_Programs();
        }
        [TestMethod]
        [DataRow(1234, 4321)]
        [DataRow(4321, 1234)]
        public void ReverseNumber_WhenNumberisGiven_ItReturns_ReverseNumber(int number, int expected)
        {

            int result = objLogicalPrograms.Reverse_Number(number);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(6, false)]
        [DataRow(7, true)]
        [DataRow(19, true)]
        [DataRow(30, false)]


        public void PrimeNumber_WhenNumberIsGiven_ItReturns_TrueOrFalse(int number, bool expected)
        {
            bool result = objLogicalPrograms.Prime_Number(number);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [DataRow(23, false)]
        [DataRow(10, false)]
        [DataRow(28, true)]
        public void PerfectNumber_WhenNumberisGiven_ItReturns_TrueOrFalse(int number, bool expected)
        {
            bool result = objLogicalPrograms.Perfect_Number(number);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(10, 144)]
        [DataRow(8, 55)]
        [DataRow(5, 13)]
        public void FibonacciSeries_WhenNumberIsGiven_ItReturns_LastNumberOfTheSeries(int number, int expected)
        {
            int result = objLogicalPrograms.Fibanocci_Series(number);
            Assert.AreEqual(expected, result);
        }
    }
}