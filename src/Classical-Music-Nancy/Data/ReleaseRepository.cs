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
				/* Ideally would want to narrow it down in query, rather than retrieving ALL nodes,
				 * but the query line below doesn't issue valid Cypher, so I'm narrowing the results
				 * down further below instead.*/
				//.Where((Model.Release node) => node.Id == 2)
				.Return(node => node.As<Model.Release>());

			var queryResults = query.Results;
			if (queryResults.Any())
			{
				var relevantReleases = query.Results.Where(i => i.Id == releaseId);
				return relevantReleases.FirstOrDefault();
			}

			throw new Exception("No releases found in database.");
		}
	}

	public interface IReleaseRepository
	{
		Model.Release GetFromDb(int releaseId);
	}
}