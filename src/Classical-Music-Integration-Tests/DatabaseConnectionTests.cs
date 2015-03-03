using Classical_Music_Nancy.Status;
using NUnit.Framework;

namespace Classical_Music_Integration_Tests
{
	[TestFixture]
	public class DatabaseConnectionTests
	{
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
	}
}