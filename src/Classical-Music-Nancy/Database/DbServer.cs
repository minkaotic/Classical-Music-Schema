using System;
using Neo4jClient;

namespace Classical_Music_Nancy
{
	public class DbServer
	{
		private string _dbUrl;

		public DbServer(string dbUrl)
		{
			_dbUrl = dbUrl;
		}

		public bool Connect()
		{
			try
			{
				var client = new GraphClient(new Uri(_dbUrl));
				client.Connect();
				return true;
			}
			catch (AggregateException)
			{
				return false;
			}

		}
	}
}