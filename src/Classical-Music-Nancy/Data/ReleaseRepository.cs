using System;
using System.Linq;
using Neo4jClient;

namespace Classical_Music_Nancy.Data
{
	public class ReleaseRepository : IReleaseRepository
	{
		private string _dbUri = "http://10.120.17.75:7474/db/data";

		public Release.Release GetFromDb()
		{
			var client = new GraphClient(new Uri(_dbUri));
			client.Connect();

			var query = client
				.Cypher
				.Match("(node:Release)")
				.Return(node => node.As<Release.Release>());

			var queryResults = query.Results;
			if (queryResults.Any())
			{
				return query.Results.FirstOrDefault();
			}

			throw new Exception("No releases found in database.");
		}
	}

	public interface IReleaseRepository
	{
		Release.Release GetFromDb();
	}
}