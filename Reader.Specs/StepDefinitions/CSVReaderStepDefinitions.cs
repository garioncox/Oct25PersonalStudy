using Oct25PersonalStudy;
using System;
using TechTalk.SpecFlow;

namespace Reader.Specs.StepDefinitions
{
    [Binding]
    public class CSVReaderStepDefinitions
    {
        private readonly ScenarioContext _sc;
        public CSVReaderStepDefinitions(ScenarioContext sc)
        {
            _sc = sc;
        }
        [Given(@"the dataset ""([^""]*)""")]
        public void GivenTheDataset(string filePath)
        {
            _sc.Add("reader", new CSVReader(filePath));
        }

        [Given(@"the data is successfully read")]
        public void GivenTheDataIsSuccessfullyRead()
        {
            CSVReader r = _sc.Get<CSVReader>("reader");
            r.ReadData().Should().Be(true);
        }

        [Then(@"the label should be (.*)")]
        public void ThenTheLabelShouldBe(int p0)
        {
            CSVReader r = _sc.Get<CSVReader>("reader");
            r.GetData("label").Should().Be(p0);
        }

        [Then(@"first datapoint should be (.*)")]
        public void ThenFirstDatapointShouldBe(int p0)
        {
            CSVReader r = _sc.Get<CSVReader>("reader");
            r.GetData("d1").Should().Be(p0);
        }

        [Then(@"second datapoint should be (.*)")]
        public void ThenSecondDatapointShouldBe(int p0)
        {
            CSVReader r = _sc.Get<CSVReader>("reader");
            r.GetData("d2").Should().Be(p0);
        }

        [Then(@"third datapoint should be (.*)")]
        public void ThenThirdDatapointShouldBe(int p0)
        {
            CSVReader r = _sc.Get<CSVReader>("reader");
            r.GetData("d3").Should().Be(p0);
        }

        [Then(@"fourth datapoint should be (.*)")]
        public void ThenFourthDatapointShouldBe(int p0)
        {
            CSVReader r = _sc.Get<CSVReader>("reader");
            r.GetData("d4").Should().Be(p0);
        }
    }
}
