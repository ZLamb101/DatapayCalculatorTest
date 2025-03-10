# Tax Calculator Exercise

## Task
Assuming this is a new project, you have been tasked with implementing the first unit tests for the `TaxCalculator` class. Please create unit tests that consider the following principles:
- **Maintainability:** Write tests that are easy to understand and modify.
- **Future Proofing:** Anticipate potential changes in requirements and design tests accordingly.
- **Readability:** Keep the tests straightforward and easy to read, focusing on specific functionalities without unnecessary complexity.

## Description
The `TaxCalculator` class is designed to calculate PAYE (Pay As You Earn) tax, student loan repayments, and KiwiSaver contributions based on the provided income. The class handles various edge cases and provides accurate calculations. It also includes special handling for specific bank deals. Notably, PAYE is calculated after any deductions are applied to the income.

## Acceptance Criteria

### CalculatePAYE Method
- **Input:**
  - `income` (double): The income amount.
  - `bank` (string): The bank name.
  - `deduction` (double, optional): The deduction amount. Default is 0.
  
- **Output:**
  - Returns the calculated PAYE tax as a double.

- **Behavior:**
  - If `income` is negative, throw an `ArgumentException`.
  - If `deduction` is negative, throw an `ArgumentException`.
  - If `bank` is null or empty, throw an `ArgumentException`.
  - Check for special bank deals:
    - If the bank is "Eastpac" and the income is exactly $100,000, return 0.
  - Subtract the `deduction` from the `income`.
  - If the resulting income is negative, set it to 0.
  - Calculate the tax based on the following brackets:
    - 10% for income up to $14,000.
    - 17% for income from $14,001 to $48,000.
    - 30% for income from $48,001 to $70,000.
    - 33% for income over $70,000.
  - Ensure the tax calculation is accurate for income values at the boundaries of each tax bracket.

### CalculateStudentLoan Method
- **Input:**
  - `income` (double): The income amount.

- **Output:**
  - Returns the calculated student loan repayment as a double.

- **Behavior:**
  - If `income` is negative, throw an `ArgumentException`.
  - Calculate the student loan repayment as 12% of the `income`.
  - Cap the student loan repayment at $4,000.

### CalculateKiwiSaver Method
- **Input:**
  - `income` (double): The income amount.

- **Output:**
  - Returns the calculated KiwiSaver contribution as a double.

- **Behavior:**
  - If `income` is negative, throw an `ArgumentException`.
  - Calculate the KiwiSaver contribution as 3% of the `income`.

## Error Handling
Ensure that all methods handle invalid inputs gracefully by throwing appropriate exceptions.
