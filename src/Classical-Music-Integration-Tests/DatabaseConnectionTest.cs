using Classical_Music_Nancy.Data;
using Classical_Music_Nancy.Model;
using Classical_Music_Nancy.Status;
using NUnit.Framework;

namespace Classical_Music_Integration_Tests
{
	[TestFixture]
	public class DatabaseConnectionTest
	{
		private Release _release;

		[TestFixtureSetUp]
		public void Set_up()
		{
			var releaseData = new ReleaseRepository();
			var releaseId = 1;
			_release = releaseData.GetFromDb(releaseId);
		}

		[Test]
		public void Can_connect_to_the_database()
		{
			var database = new DbServer("http://10.120.17.75:7474/db/data");
			database.Connect();

			Assert.That(database.Status, Is.EqualTo("ONLINE"));
		}

		[Test, Ignore("takes too long")]
		public void Cannot_connect_to_non_existant_database()
		{
			var database = new DbServer("http://10.120.17.75:7475/db/data");
			database.Connect();

			Assert.That(database.Status, Is.Not.EqualTo("ONLINE"));
		}

		[Test]
		public void It_can_get_a_release_title_from_the_database()
		{
			Assert.That(_release.Title, Is.EqualTo("Mahler: Symphony No. 1"));
		}

	}
}
