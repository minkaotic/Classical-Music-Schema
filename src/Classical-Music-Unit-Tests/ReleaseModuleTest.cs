using Classical_Music_Nancy.Data;
using Classical_Music_Nancy.Model;
using Classical_Music_Nancy.Release;
using NUnit.Framework;
using Nancy.Testing;

namespace Classical_Music_Unit_Tests
{
	[TestFixture]
	class ReleaseModuleTest
	{
		private Browser _browser;
		private ReleaseRepositoryMock _releaseRepository;

		[SetUp]
		public void SetUp()
		{
			_releaseRepository = new ReleaseRepositoryMock();

			_browser = new Browser(x =>
			{
				x.Module<ReleaseModule>();
				x.Dependency(_releaseRepository);
			});
		}

		[Test]
		public void Release_1_returns_title()
		{
			var response = _browser.Get(string.Format("/release/1"), with =>
			{
				with.Header("Accept", "application/json");
			}); 
			
			Assert.That(response.Body.AsString(), Is.StringContaining("\"title\":\"Test Name\""));
		}

		[Test]
		public void Release_2_returns_title()
		{
			var response = _browser.Get(string.Format("/release/2"), with =>
			{
				with.Header("Accept", "application/json");
			});

			Assert.That(response.Body.AsString(), Is.StringContaining("\"title\":\"Another Test Name\""));
		}

		private class ReleaseRepositoryMock : IReleaseRepository
		{
			public Release GetFromDb(int releaseId)
			{
				if (releaseId == 1)
				{
					return new Release() { Name = "Test Name" };
				}

				return new Release() { Name = "Another Test Name" };
			}
		}
	}
}
