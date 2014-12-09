using System.Configuration;
using System.Net;
using System.Text;
using NUnit.Framework;

namespace Classical_Music_Acceptance_Tests
{
    [TestFixture]
    public class StatusEndpointTests
    {
        [Test]
        public void It_should_return_Database_online()
        {
            var url = ConfigurationManager.AppSettings["RootUrl"] + "/status";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            string responseText;

            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), ASCIIEncoding.ASCII))
            {
                responseText = reader.ReadToEnd();
            }
    
            Assert.That(responseText, Is.EqualTo("Database: ONLINE"));
        }
    }
}
