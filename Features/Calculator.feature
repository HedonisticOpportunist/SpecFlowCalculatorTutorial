Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@CalculatorTests
Scenario: Add two numbers - happy path
	Given the first number is 250
	And the second number is 100
	When the two numbers are added
	Then the result should be 350

Scenario: Add two numbers - unhappy path
	Given the first number is 250
	And the second number is 100
	When the two numbers are added
	Then the result should not be 1200

Scenario: Subtract two numbers - happy path
	Given the first number is 100
	And the second number is 30
	When the two numbers are subtracted
	Then the result should be 70

Scenario: Subtract two numbers - unhappy path
	Given the first number is 100
	And the second number is 30
	When the two numbers are subtracted
	Then the result should not be 85

Scenario: Divide first number by the second - happy path
	Given the first number is 100
	And the second number is 50
	When the first number is divided by the second
	Then the result should be 2

Scenario: Divide first number by the second - unhappy path
	Given the first number is 100
	And the second number is 50
	When the first number is divided by the second
	Then the result should not be 80

Scenario: Multiply the numbers - happy path
	Given the first number is 10
	And the second number is 2
	When the numbers are muliplied
	Then the result should be 20

Scenario: Multiply the numbers - unhappy path
	Given the first number is 10
	And the second number is 2
	When the numbers are muliplied
	Then the result should not be 10

Scenario: Get the modulus of the first number divided by the second
	Given the first number is 10
	And the second number is 2
	When the modulus is calculated
	Then the result should be 0

Scenario: Get the the exponential of the firt number by the second
	Given the first number is 1
	And the second number is 2
	When the expontial is calculated
	Then the result should be a decimal of 1.0