using Classical_Music_Nancy;
using Classical_Music_Nancy.Data;
using Classical_Music_Nancy.Release;
using Moq;
using NUnit.Framework;
using Nancy.Testing;

namespace Classical_Music_Unit_Tests
{
	[TestFixture]
	class ReleasePageModuleTest
	{
		[Test]
		public void Returns_release_data_which_is_passed_in()
		{
			var releaseDataMock = new Mock<IReleaseRepository>();
			releaseDataMock.Setup(rdm => rdm.GetFromDb()).Returns(new Release { Title = "Test Title" });
			var releasePageModule = new ReleaseModule(releaseDataMock.Object);
			var testingBootstrapper = new ConfigurableBootstrapper(with => with.Module(releasePageModule));
			var browser = new Browser(testingBootstrapper, to => to.Accept("application/json"));
			var responseText = browser.Get("/release/1", with => with.HttpRequest()).Body.AsString();

			Assert.That(responseText, Is.StringContaining("Test Title"));
		}
	}
}
