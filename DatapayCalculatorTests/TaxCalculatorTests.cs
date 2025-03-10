using DatapayCalculatorTest;

namespace DatapayCalculatorTests
{
    public class TaxCalculatorTests
    {
        private TaxCalculator _taxCalculator;

        public TaxCalculatorTests()
        {
            _taxCalculator = new TaxCalculator();
        }

        [Fact]
        public void TestCalculateTax_IncomeOfZero()
        {
            Assert.Equal(0, _taxCalculator.CalculatePAYE(0), 2);
        }

        [Fact]
        public void TestCalculateTax_BoundaryConditions()
        {
            Assert.Equal(1400, _taxCalculator.CalculatePAYE(14000), 2);
            Assert.Equal(2380, _taxCalculator.CalculatePAYE(20000), 2);
            Assert.Equal(5660, _taxCalculator.CalculatePAYE(48000), 2);
            Assert.Equal(11680, _taxCalculator.CalculatePAYE(60000), 2);
            Assert.Equal(14560, _taxCalculator.CalculatePAYE(70000), 2);
        }

        [Fact]
        public void TestCalculateTax_NegativeIncome()
        {
            Assert.Throws<ArgumentException>(() => _taxCalculator.CalculatePAYE(-5000));
        }
    }
}