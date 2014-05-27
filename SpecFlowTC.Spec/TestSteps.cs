using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowTC.Spec
{
    [Binding]
    public class TestSteps
    {
        public List<int> Inputs = new List<int>();
        public int Result = 0;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Inputs.Add(p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Result = Inputs.Aggregate(0, (current, input) => current + input);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, Result);
        }
    }
}
