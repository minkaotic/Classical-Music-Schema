using System;
using Nancy;
using Neo4jClient;

namespace Classical_Music_Nancy
{
    public class StatusModule : NancyModule
    {        

        public StatusModule()
        {
            Get["/status"] = parameters => GetStatus();            
        }

        private static string GetStatus()
        {
            var databaseConnection = new DatabaseConnection("http://10.120.17.75:7474/db/data");
            if (databaseConnection.ConnectToDB())
                return DbOnline();
            else
                return DbNotFound();
        }

        private static string DbNotFound()
        {
            return "Database: NOT FOUND";
        }

        private static string DbOnline()
        {
            return "Database: ONLINE";
        }
    }
}