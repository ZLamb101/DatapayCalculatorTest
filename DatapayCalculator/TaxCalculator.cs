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

    // KiwiSaver contribution rate
    private const double KiwiSaverRate = 0.03; // 3%

    // Special deal value for Eastpac
    private const double EastpacDealValue = 100000;

    public double CalculateTax(double income, string bank)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative.");
        }
        
        if (string.IsNullOrEmpty(bank))
        {
            throw new ArgumentException("Bank cannot be null or empty.");
        }

        if (HasBankDeal(bank, income))
        {
            return 0; // Special deal for the bank
        }
        
        double tax = 0;

        if (income <= 14000)
        {
            tax = income * TaxRate1;
        }
        else if (income <= 48000)
        {
            tax =  (income) * TaxRate2;
        }
        else if (income <= 70000)
        {
            tax = (income - 48000) * TaxRate3;
        }
        else
        {
            tax = (income - 70000) * TaxRate4;
        }

        return tax;
    }
    
    private bool HasBankDeal(string bank, double income)
    {
        return bank == "Eastpac" && income.Equals(EastpacDealValue);
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

    public double CalculateKiwiSaver(double income)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative.");
        }

        return income * KiwiSaverRate;
    }
}