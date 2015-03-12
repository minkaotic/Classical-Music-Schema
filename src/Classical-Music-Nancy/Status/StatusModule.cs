using System.Reflection;
using Nancy;

namespace Classical_Music_Nancy.Status
{
	public class StatusModule : NancyModule
	{
		private readonly IDbServer _dbServer;
		private readonly IAssemblyInformation _assemblyInformation;
		private readonly IServerInformation _serverInformation;

		public StatusModule(IDbServer dbServer, IAssemblyInformation assemblyInformation, IServerInformation serverInformation)
		{
			_dbServer = dbServer;
			_assemblyInformation = assemblyInformation;
			_serverInformation = serverInformation;
			Get["/status"] = _ => StatusResponse();
		}

		private string StatusResponse()
		{
			return "\"serverTime\": \"" +  FormattedServerTime() + "\"";
		}

		private string FormattedServerTime()
		{
			return _serverInformation.DateTimeInUtc().ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'");
		}
	}
}