using Classical_Music_Nancy.Data;
using Classical_Music_Nancy.Model;
using NUnit.Framework;

namespace Classical_Music_Integration_Tests
{
	[TestFixture]
	public class DataRetrievalTests
	{
		[TestCase(1, "Mahler: Symphony No. 1")]
		//TODO: [TestCase(2, "Gustav Mahler: Symphonies")]
		public void It_can_get_a_release_title_from_the_database(int releaseId, string expectedReleaseTitle)
		{
			var releaseData = new ReleaseRepository();
			var release = releaseData.GetFromDb(releaseId);
			var actual = release.Title;

			Assert.That(actual, Is.EqualTo(expectedReleaseTitle));
		}
	}
}
