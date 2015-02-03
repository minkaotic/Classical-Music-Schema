using System.Net;
using NUnit.Framework;

namespace Classical_Music_Acceptance_Tests.Specs
{
	public class ReleaseIdEndpointStepsDriver
	{
		public void AddReleaseToDatabase()
		{
			AssertDatabaseApiIsLive();
			AssertReleaseExistsInDatabase();
		}

		private void AssertReleaseExistsInDatabase()
		{
			throw new System.NotImplementedException();
		}

		private void AssertDatabaseApiIsLive()
		{
			var webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:7474/db/data/");
			var webResponse = (HttpWebResponse)webRequest.GetResponse();
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