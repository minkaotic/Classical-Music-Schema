using Classical_Music_Nancy.Data;
using Nancy;

namespace Classical_Music_Nancy.Release
{
	public class ReleaseModule : NancyModule
	{
		private readonly IReleaseRepository _releaseRepository;

		public ReleaseModule(IReleaseRepository releaseRepository)
		{
			_releaseRepository = releaseRepository;
			Get["/release/1"] = parameters => ReleaseResponse();
		}

		private Release ReleaseResponse()
		{
			return _releaseRepository.GetFromDb();
		}
	}
}
