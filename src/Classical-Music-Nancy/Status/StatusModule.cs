using System.Reflection;
using Nancy;

namespace Classical_Music_Nancy.Status
{
	public class StatusModule : NancyModule
	{
		private static readonly DbServer DbServer = new DbServer("http://10.120.17.75:7474/db/data");
		
		public StatusModule()
		{
			Get["/status"] = _ => StatusResponse();
		}

		private static string StatusResponse()
		{
			
			DbServer.Connect();
			return DbStatus() + "<p/>" + OutputVersionNumber();
		}

		private static string DbStatus()
		{
			if (DbServer.Status == "ONLINE")
			{
				return "Database: ONLINE";
			}
			return "Database: CONNECTION ERROR";
		}

		private static string OutputVersionNumber()
		{
			return "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
		}
	}
}