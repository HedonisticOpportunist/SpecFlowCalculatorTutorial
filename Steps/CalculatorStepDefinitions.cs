using CalculatorSUT;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;
        private double _doubleResult;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are subtracted")]
        public void WhenTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When("the expontial is calculated")]
        public void WhenTheExpontialIsCalculated()
        {
            _doubleResult = _calculator.Exponential();
        }

        [When("the first number is divided by the second")]
        public void WhenTheFirstNumberIsDividedByTheSecond()
        {
            _result = _calculator.Divide();
        }

        [When("the numbers are muliplied")]
        public void WhenTheNumbersAreMulitplied()
        {
            _result = _calculator.Mulitiply();
        }

        [When("the modulus is calculated")]
        public void WhenTheModulusIsCalculated()
        {
            _result = _calculator.Modulo();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Then("the result should not be (.*)")]
        public void ThenTheResultShouldNotBe(int result)
        {
            _result.Should().NotBe(result);
        }

        [Then("the result should be a decimal of (.*)")]
        public void ThenTheResultShouldBe(double result)
        {
            _doubleResult.Should().Be(result);
        }
    }
}
