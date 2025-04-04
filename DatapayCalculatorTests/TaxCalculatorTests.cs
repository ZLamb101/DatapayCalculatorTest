using Xunit;
using DatapayCalculatorTest;
using NUnit.Framework;
using Assert = Xunit.Assert;

namespace DatapayCalculatorTests
{
    public class TaxCalculatorTests
    {
        private TaxCalculator _taxCalculator;

        public TaxCalculatorTests()
        {
            _taxCalculator = new TaxCalculator();
        }
        
        public void testCalculateTax()
        {
            Assert.Matches(1400.ToString(), _taxCalculator.CalculateTax(14000, "ASB").ToString());
        }

    }
}