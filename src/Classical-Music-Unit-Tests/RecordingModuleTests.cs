using Classical_Music_Nancy.Data;
using Classical_Music_Nancy.Endpoints.Recording;
using Classical_Music_Nancy.Model;
using Classical_Music_Nancy.Release;
using NUnit.Framework;
using Nancy.Testing;

namespace Classical_Music_Unit_Tests
{
	class RecordingModuleTests
	{
		private Browser _browser;
		private RecordingRepositoryMock _recordingRepository;

		[SetUp]
		public void SetUp()
		{
			_recordingRepository = new RecordingRepositoryMock();

			_browser = new Browser(x =>
			{
				x.Module<RecordingModule>();
				x.Dependency(_recordingRepository);
			});
		}

		[Test]
		public void Recording_1_returns_expected_information()
		{
			var response = _browser.Get(string.Format("/recording/1"), with =>
			{
				with.Header("Accept", "application/json");
			});

			Assert.That(response.Body.AsString(), Is.StringContaining("1"));
			Assert.That(response.Body.AsString(), Is.StringContaining("conductor"));
		}

		[Test]
		public void Release_2_returns_expected_information()
		{
			var response = _browser.Get(string.Format("/recording/2"), with =>
			{
				with.Header("Accept", "application/json");
			});

			Assert.That(response.Body.AsString(), Is.StringContaining("2"));
		}

		private class RecordingRepositoryMock : IRecordingRepository
		{
			public Recording GetFromDb(int recordingId)
			{
				if (recordingId == 1)
				{
					return new Recording() { Id = 1, Conductor = "Zubin Mehta" };
				}

				return new Recording() { Id = 2, Conductor = "Darren W. Chamberlain" };
			}
		}
	}
}
