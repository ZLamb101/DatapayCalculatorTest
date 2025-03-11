# Tax Calculator Exercise

## Task
Assuming this is a new project, you have been tasked with implementing the first unit tests for the `TaxCalculator` class. Please create unit tests that consider the following principles:
- **Maintainability:** Write tests that are easy to understand and modify.
- **Future Proofing:** Anticipate potential changes in requirements and design tests accordingly.
- **Readability:** Keep the tests straightforward and easy to read, focusing on specific functionalities without unnecessary complexity.

## Description
The `TaxCalculator` class is designed to calculate tax, student loan repayments, and KiwiSaver contributions based on the provided income. The class handles various edge cases and provides accurate calculations.

## Acceptance Criteria

- When I calculate my tax with earnings below or equal to $14,000,
Then my tax should be earnings * 0.10.
- When I calculate my tax with earnings between $14,001 and $48,000,
Then my tax should be earnings  * 0.17.
- When I calculate my tax with earnings above $70,000,
Then my tax should earnings * 0.33.
- When I calculate my tax with earnings of exactly $100,000 and my bank is "Eastpac",
Then my tax should be 0.
- When I calculate my tax with negative earnings,
Then I should receive an error message indicating that the input is invalid.
- When I calculate my tax with a null or empty bank name,
Then I should receive an error message indicating that the input is invalid.
- When I calculate my student loan repayment with earnings above the repayment cap threshold,
Then my repayment should be capped at $4,000.
- When I calculate my student loan repayment with earnings below or equal to the repayment cap threshold,
Then my repayment should be earnings * 0.12.
- When I calculate my KiwiSaver contribution with earnings,
Then my contribution should be earnings * 0.03.
