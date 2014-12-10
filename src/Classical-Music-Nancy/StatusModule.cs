using System.Reflection;
using Nancy;

namespace Classical_Music_Nancy
{
    public class StatusModule : NancyModule
    {        

        public StatusModule()
        {
            Get["/status"] = parameters => RenderStatusPage();            
        }

        private static string RenderStatusPage()
        {
            var newline = "<p/>";
            var databaseConnection = new DatabaseConnection("http://10.120.17.75:7474/db/data");
            if (databaseConnection.ConnectToDB())
                return DbOnline() + newline + OutputVersionNumber();
            else
                return DbNotFound();
        }

        private static string OutputVersionNumber()
        {
            return "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
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