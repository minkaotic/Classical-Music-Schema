using Classical_Music_Nancy.Data;
using NUnit.Framework;

namespace Classical_Music_Integration_Tests
{
	[TestFixture]
	public class DataRetrievalTests
	{
		[TestCase(741553, "Mahler: Symphony No. 1")]
		[TestCase(162673, "Gustav Mahler: Symphonies")]
		public void It_can_get_release_information_from_the_database(int sevenDigitalId, string expectedReleaseTitle)
		{
			var releaseData = new ReleaseRepository();
			var release = releaseData.GetFromDb(sevenDigitalId);
			var actual = release.Name;

			Assert.That(actual, Is.EqualTo(expectedReleaseTitle));
		}
	}
}
