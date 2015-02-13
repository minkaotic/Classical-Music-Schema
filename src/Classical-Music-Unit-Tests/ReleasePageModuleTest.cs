using Classical_Music_Nancy;
using Classical_Music_Nancy.Database;
using Moq;
using NUnit.Framework;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Testing;

namespace Classical_Music_Unit_Tests
{
	[TestFixture]
	class ReleasePageModuleTest
	{
		[Test]
		public void foo()
		{
			var releaseDataMock = new Mock<IReleaseData>();
			releaseDataMock.Setup(rdm => rdm.GetFromDb()).Returns(new Release { Title = "Blah" });
			var releasePageModule = new ReleasePageModule(releaseDataMock.Object);
			var testingBootstrapper = new ConfigurableBootstrapper(with => with.Module(releasePageModule));
			var browser = new Browser(testingBootstrapper, to => to.Accept("application/json"));
			var responseText = browser.Get("/release/1", with => with.HttpRequest()).Body.AsString();
			Assert.That(responseText, Is.StringContaining("Blah"));
		}
	}
}
