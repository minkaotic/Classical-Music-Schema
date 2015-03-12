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
			Get["/release/{releaseId}"] = parameters =>
				{
					var releaseId = parameters.releaseId;
					return _releaseRepository.GetFromDb(releaseId);
				};
		}
	}
}
