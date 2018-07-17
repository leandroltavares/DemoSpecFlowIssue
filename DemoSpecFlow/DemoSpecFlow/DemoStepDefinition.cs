using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace DemoSpecFlow
{
    [Binding]
    public sealed class DemoStepDefinition
    {
        [Given("that I used a step with accents like á or ã and parameter (.*)")]
        public void SampleAccentStep(string parameter)
        {
            Assert.IsTrue(parameter.Contains("á") && parameter.Contains("ã"));
        }
    }
}
