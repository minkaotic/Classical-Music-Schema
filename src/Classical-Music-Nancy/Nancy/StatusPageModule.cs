using System.Reflection;
using Nancy;

namespace Classical_Music_Nancy
{
    public class StatusPageModule : NancyModule
    {        

        public StatusPageModule()
        {
            Get["/status"] = parameters => StatusPageResponse();            
        }

        private static string StatusPageResponse()
        {
            var databaseConnection = new DatabaseConnection("http://10.120.17.75:7474/db/data");
            if (databaseConnection.ConnectToDb())
            {
                return DbOnline() + "<p/>" + OutputVersionNumber();
            }
            else
                return DbNotFound();
        }

        private static string OutputVersionNumber()
        {
            return "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
        }
        
        private static string DbOnline()
        {
            return "Database: ONLINE";
        }

        private static string DbNotFound()
        {
            return "Database: NOT FOUND";
        }
    }
}