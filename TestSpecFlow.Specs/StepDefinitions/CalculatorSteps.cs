using System;
using TechTalk.SpecFlow;
using Xunit;

namespace TestSpecFlow.Specs.StepDefinitions
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator;

        public CalculatorSteps()
        {
            calculator = new Calculator();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calculator.Input1 = p0;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            calculator.Input2 = p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.Sum();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.Equal(p0, calculator.Result);
        }
    }
}
