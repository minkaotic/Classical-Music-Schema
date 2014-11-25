using Classical_Music_Schema;
using System.Net;
using NUnit.Framework;

namespace WalkingSkeleton.Tests
{
    [TestFixture]
    public class WalkingSkeletonTests
    {
        [Test]
        public void It_should_return_a_status_code_of_200()
        {
            var url = "http://www.google.co.uk";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();

            Assert.That(((HttpWebResponse)response).StatusCode,Is.EqualTo(HttpStatusCode.OK));

        }
    }
}
