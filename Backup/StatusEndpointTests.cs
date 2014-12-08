using System;
using System.IO;
using System.Net;
using System.Text;
using NUnit.Framework;
using Neo4jClient;

namespace Classical_Music_Acceptance_Tests
{
    [TestFixture]
    public class StatusEndpointTests
    {
        [Test]
        public void It_should_return_a_status_code_of_200()
        {
            var url = "http://classical-api.local/status";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            string responseText;

            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), ASCIIEncoding.ASCII))
            {
                responseText = reader.ReadToEnd();
            }

            Assert.That(((HttpWebResponse)response).StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(responseText, Is.EqualTo("Database: ONLINE"));
            Assert.That(5+6,Is.EqualTo(11));
        }

        [Test]
        public void It_should_connect_to_the_database()
        {
            var client = new GraphClient(new Uri("http://10.120.17.75:7474/db/data"));
            client.Connect();


        }
    }
}
