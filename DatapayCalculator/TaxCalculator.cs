namespace DatapayCalculatorTest;

using System;

public class TaxCalculator
{
    // Tax rates (fictional for this example)
    private const double TaxRate1 = 0.10; // 10% for income up to $14,000
    private const double TaxRate2 = 0.17; // 17% for income from $14,001 to $48,000
    private const double TaxRate3 = 0.30; // 30% for income from $48,001 to $70,000
    private const double TaxRate4 = 0.33; // 33% for income over $70,000

    // Student loan repayment rate
    private const double StudentLoanRate = 0.12; // 12%
    private const double StudentLoanThreshold = 4000; // Maximum student loan repayment

    public double CalculateTax(double income)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative.");
        }
        
        double tax = 0;

        if (income <= 14000)
        {
            tax = income * TaxRate1;
        }
        else if (income <= 47000)
        {
            tax =  (income) * TaxRate2;
        }
        else if (income <= 70000)
        {
            tax = (income) * TaxRate3;
        }
        else
        {
            tax = (income) * TaxRate4;
        }

        return tax;
    }

    public double CalculateStudentLoan(double income)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative.");
        }

        double studentLoan = income * StudentLoanRate;
        return studentLoan > StudentLoanThreshold ? StudentLoanThreshold : studentLoan;
    }
}