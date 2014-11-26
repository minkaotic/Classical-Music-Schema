using System.Net;
using NUnit.Framework;

namespace Classical_Music_Acceptance_Tests
{
    [TestFixture]
    public class WalkingSkeletonTests
    {
        [Test]
        public void It_should_return_a_status_code_of_200()
        {
            var url = "http://localhost:57894/";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();

            Assert.That(((HttpWebResponse)response).StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }
    }
}
