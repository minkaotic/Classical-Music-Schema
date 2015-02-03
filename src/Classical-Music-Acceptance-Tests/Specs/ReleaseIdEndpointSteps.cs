using TechTalk.SpecFlow;

namespace Classical_Music_Acceptance_Tests.Specs
{
	[Binding]
	class ReleaseIdEndpointSteps
	{
		private ReleaseIdEndpointStepsDriver _driver;

		[Given(@"a release exists in the database")]
		public void GivenAReleaseExistsInTheDatabase()
		{
			_driver = new ReleaseIdEndpointStepsDriver();
			_driver.AddReleaseToDatabase();
		}

		[When(@"I request the release from the endpoint")]
		public void WhenIRequestTheReleaseFromTheEndpoint()
		{
			_driver.GetReleaseFromEndpoint();
		}

		[Then(@"I should see its release title")]
		public void ThenIShouldSeeItsReleaseTitle()
		{
			_driver.AssertReleaseTitleIsCorrect();
		}

	}
}
