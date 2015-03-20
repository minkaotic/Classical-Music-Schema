using Classical_Music_Nancy.Data;
using NUnit.Framework;

namespace Classical_Music_Integration_Tests
{
	[TestFixture]
	public class DataRetrievalTests
	{
		[TestCase(1, "Mahler: Symphony No. 1")]
		[TestCase(2, "Gustav Mahler: Symphonies")]
		public void It_can_get_release_information_from_the_database(int releaseId, string expectedReleaseTitle)
		{
			var releaseData = new ReleaseRepository();
			var release = releaseData.GetFromDb(releaseId);
			var actual = release.Title;

			Assert.That(actual, Is.EqualTo(expectedReleaseTitle));
		}

		[Test, Ignore("TO DO")]
		public void It_can_get_recording_information_from_the_database()
		{
			var expected = "Zubin Mehta";
			var recordingData = new RecordingRepository();
			var recording = recordingData.GetFromDb(1);
			var actual = recording.Conductor;

			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}
