using System;
using System.Linq;
using Neo4jClient;

namespace Classical_Music_Nancy.Data
{
	public class RecordingRepository : IRecordingRepository
	{
		private string _dbUri = "http://10.120.17.75:7474/db/data";

		public Model.Recording GetFromDb(int recordingId)
		{
			var client = new GraphClient(new Uri(_dbUri));
			client.Connect();

			var query = client
				.Cypher
				.Match("(node:Release)")
				.Where("id(node)={param}")
				.WithParam("param", recordingId)
				.Return(node => node.As<Model.Recording>());

			var queryResults = query.Results;
			if (queryResults.Any())
			{
				var relevantRecordings = query.Results;
				return relevantRecordings.FirstOrDefault();
			}

			throw new Exception("No releases found in database.");
		}
	}
}