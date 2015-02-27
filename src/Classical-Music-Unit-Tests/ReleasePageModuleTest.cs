using Classical_Music_Nancy.Data;
using Classical_Music_Nancy.Model;
using Classical_Music_Nancy.Release;
using NUnit.Framework;
using Nancy.Testing;

namespace Classical_Music_Unit_Tests
{
	[TestFixture]
	class ReleasePageModuleTest
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

		[Test, Ignore]
		public void Release_1_returns_title()
		{
			var response = _browser.Get(string.Format("/release/1"), with =>
			{
				with.Header("Accept", "application/json");
			}); 
			
			Assert.That(response.Body.AsString(), Is.EqualTo("{\"title\":\"Test Title\"}"));
		}

		[Test, Ignore]
		public void Release_2_returns_title()
		{
			var response = _browser.Get(string.Format("/release/2"), with =>
			{
				with.Header("Accept", "application/json");
			});

			Assert.That(response.Body.AsString(), Is.EqualTo("{\"title\":\"Another Test Title\"}"));
		}

		private class ReleaseRepositoryMock : IReleaseRepository
		{
			public Release GetFromDb(int releaseId)
			{
				if (releaseId == 1)
				{
					return new Release() { Title = "Test Title" };
				}

				return new Release() { Title = "Another Test Title" };
			}
		}
	}
}
