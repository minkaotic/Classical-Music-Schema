using System;
using Neo4jClient;

namespace Classical_Music_Nancy
{
    public class DatabaseConnection
    {
        private string _dbUrl;

        public DatabaseConnection(string dbUrl)
        {
            _dbUrl = dbUrl;
        }

        public bool ConnectToDb()
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