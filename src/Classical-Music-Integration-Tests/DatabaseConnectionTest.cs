using Classical_Music_Nancy;
using Classical_Music_Nancy.Database;
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
            _release = ReleaseData.GetFromDb();
        }

        [Test]
        public void It_can_connect_to_the_database()
        {
            var databaseConnection = new DatabaseConnection("http://10.120.17.75:7474/db/data");
            Assert.That(databaseConnection.ConnectToDb(),Is.True);
        }

        [Test]
        public void It_cannot_connect_to_non_existant_database()
        {
            var databaseConnection = new DatabaseConnection("http://10.120.17.75:7475/db/data");
            Assert.That(databaseConnection.ConnectToDb(), Is.False);
        }

        [Test]
        public void It_can_get_a_release_title_from_the_database()
        {
            Assert.That(_release.Title, Is.EqualTo("Mahler: Symphony No. 1"));
        }

    }
}
