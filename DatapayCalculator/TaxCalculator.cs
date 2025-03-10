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

    public double CalculatePAYE(double income, string bank, double deduction = 0)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative.");
        }

        if (deduction < 0)
        {
            throw new ArgumentException("Deduction cannot be negative.");
        }
        
        if (string.IsNullOrEmpty(bank))
        {
            throw new ArgumentException("Bank cannot be null or empty.");
        }

        if (HasBankDeal(bank, income))
        {
            return 0; // Special deal for the bank
        }

        income = ApplyDeduction(income, deduction);

        return CalculateTax(income);
    }
    
    private bool HasBankDeal(string bank, double income)
    {
        return bank == "Eastpac" && income.Equals(EastpacDealValue);
    }
    
    private double ApplyDeduction(double income, double deduction)
    {
        income -= deduction;
        return income < 0 ? 0 : income;
    }

    private double CalculateTax(double income)
    {
        double tax = 0;

        if (income <= 14000)
        {
            tax = income * TaxRate1;
        }
        else if (income <= 48000)
        {
            tax = (14000 * TaxRate1) + ((income - 14000) * TaxRate2);
        }
        else if (income <= 70000)
        {
            tax = (14000 * TaxRate1) + ((48000 - 14000) * TaxRate2) + ((income - 48000) * TaxRate3);
        }
        else
        {
            tax = (14000 * TaxRate1) + ((48000 - 14000) * TaxRate2) + ((70000 - 48000) * TaxRate3) + ((income - 70000) * TaxRate4);
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

    public double CalculateKiwiSaver(double income)
    {
        if (income < 0)
        {
            throw new ArgumentException("Income cannot be negative.");
        }

        return income * KiwiSaverRate;
    }
}