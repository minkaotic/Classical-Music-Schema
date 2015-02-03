using System.Configuration;
using System.Net;
using System.Text;
using NUnit.Framework;

namespace Classical_Music_Acceptance_Tests
{
	[TestFixture]
	class ReleasePageTests
	{

		[Test]
		public void It_returns_a_release_title()
		{
			string url = ConfigurationManager.AppSettings["RootUrl"] + "/release/1";
			WebRequest request = WebRequest.Create(url);
			WebResponse response = request.GetResponse();
			string responseText;

			using (var reader = new System.IO.StreamReader(response.GetResponseStream(), ASCIIEncoding.ASCII))
			{
				responseText = reader.ReadToEnd();
			}

			Assert.That(responseText, Is.StringContaining(@"""title"":""Mahler: Symphony No. 1"""));
		}
	}
}


