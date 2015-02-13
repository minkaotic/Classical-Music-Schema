using Classical_Music_Nancy.Database;
using Nancy;

namespace Classical_Music_Nancy
{
	public class ReleasePageModule : NancyModule
	{
		private readonly IReleaseData _releaseData;

		public ReleasePageModule(IReleaseData releaseData)
		{
			_releaseData = releaseData;
			Get["/release/1"] = parameters => ReleaseResponse();
		}

		private Release ReleaseResponse()
		{
			return _releaseData.GetFromDb();
		}
	}
}
