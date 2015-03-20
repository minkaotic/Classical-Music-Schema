using System;
using Neo4jClient;

namespace Classical_Music_Nancy.Status
{
	public class DbServer
	{
		private string _dbUrl;
		public string Status;

		public DbServer(string dbUrl)
		{
			_dbUrl = dbUrl;
		}

		public void Connect()
		{
			try
			{
				var client = new GraphClient(new Uri(_dbUrl));
				client.Connect();
				Status = "ONLINE";
			}
			catch (AggregateException)
			{
				Status = "CONNECTION ERROR";
			}
		}
	}
}