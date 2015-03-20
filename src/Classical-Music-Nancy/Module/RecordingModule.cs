using Classical_Music_Nancy.Data;
using Nancy;

namespace Classical_Music_Nancy.Endpoints.Recording
{
	public class RecordingModule : NancyModule
	{
		private readonly IRecordingRepository _recordingRepository;

		public RecordingModule(IRecordingRepository recordingRepository)
		{
			_recordingRepository = recordingRepository;
			Get["/recording/{releaseId:int}"] = parameters =>
				{
					var recording =_recordingRepository.GetFromDb(parameters.releaseId);
					return recording;
				};
		}
	}
}