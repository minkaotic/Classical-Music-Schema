using Classical_Music_Nancy;
using NUnit.Framework;

namespace Classical_Music_Integration_Tests
{
    [TestFixture]
    public class DatabaseConnectionTest
    {
        [Test]
        public void It_can_connect_to_the_database()
        {
            var databaseConnection = new DatabaseConnection("http://10.120.17.75:7474/db/data");
            Assert.That(databaseConnection.ConnectToDB(),Is.True);
        }

        [Test]
        public void It_can_not_connect_to_non_existant_database()
        {
            var databaseConnection = new DatabaseConnection("http://10.120.17.75:7475/db/data");
            Assert.That(databaseConnection.ConnectToDB(), Is.False);
        }
    }
}
