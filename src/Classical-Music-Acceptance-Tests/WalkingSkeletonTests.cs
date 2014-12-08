using System;
using System.Net;
using NUnit.Framework;
using Neo4jClient;

namespace Classical_Music_Acceptance_Tests
{
    [TestFixture]
    public class WalkingSkeletonTests
    {
        [Test]
        public void It_should_return_a_status_code_of_200()
        {
            var url = "http://classical-api.svc.7d/status";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();

            Assert.That(((HttpWebResponse)response).StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }

        [Test]
        public void It_should_connect_to_the_database()
        {
            var client = new GraphClient(new Uri("http://localhost:7474/db/data"));
            client.Connect();
        }
    }
}
