using System;
using System.Linq;
using Neo4jClient;

namespace Classical_Music_Nancy.Data
{
	public class ReleaseRepository : IReleaseRepository
	{
		private string _dbUri = "http://10.120.17.75:7474/db/data";

		public Model.Release GetFromDb(int releaseId)
		{
			var client = new GraphClient(new Uri(_dbUri));
			client.Connect();

			var query = client
				.Cypher
				.Match("(node:Release)")
				.Where("id(node)= {param}")
				.WithParam("param", releaseId)
				.Return(node => node.As<Model.Release>());

			var queryResults = query.Results;
			if (queryResults.Any())
			{
				var relevantReleases = query.Results;
				return relevantReleases.FirstOrDefault();
			}

			throw new NoReleaseFoundException(releaseId, "No releases found in database: ");
		}
	}
}