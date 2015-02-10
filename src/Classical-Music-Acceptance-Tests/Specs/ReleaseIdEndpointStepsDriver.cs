using System.Net;
using NUnit.Framework;

namespace Classical_Music_Acceptance_Tests.Specs
{
	public class ReleaseIdEndpointStepsDriver
	{
		public void AssertWebsiteIsRunning()
		{
			var websiteUrl = "http://classical-api.local/status";
			AssertHttpStatusCodeIsOkFor(websiteUrl);
		}

		public void AddReleaseToDatabase()
		{
			AssertDatabaseApiIsLive();
			AssertReleaseExistsInDatabase();
		}

		private void AssertDatabaseApiIsLive()
		{
			var databaseUrl = "http://localhost:7474/db/data/";
			AssertHttpStatusCodeIsOkFor(databaseUrl);
		}

		private void AssertReleaseExistsInDatabase()
		{
			throw new System.NotImplementedException();
		}

		private void AssertHttpStatusCodeIsOkFor(string url)
		{
			var webRequest = (HttpWebRequest) WebRequest.Create(url);
			var webResponse = (HttpWebResponse) webRequest.GetResponse();
			var statusCode = webResponse.StatusCode;
			Assert.That(statusCode, Is.EqualTo(HttpStatusCode.OK));
		}

		public void GetReleaseFromEndpoint()
		{
			throw new System.NotImplementedException();
		}

		public void AssertReleaseTitleIsCorrect()
		{
			throw new System.NotImplementedException();
		}
	}
}