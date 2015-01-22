using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Neo4jClient;

namespace Classical_Music_Nancy
{
    public class Database
    {
        private const string _dbUri = "http://10.120.17.75:7474/db/data";

        public static Release GetFromDb()
        {
            var client = new GraphClient(new Uri(_dbUri));
            client.Connect();

            var query = client
                .Cypher
                .Match("(node:Release)")
                .Return(node => node.As<Release>());

            var queryResults = query.Results;
            if (queryResults.Any())
            {
                return query.Results.FirstOrDefault();
            }

            throw new Exception("No releases found. DOOM.");
        }
    }
}