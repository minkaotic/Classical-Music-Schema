using Classical_Music_Nancy.Model;

namespace Classical_Music_Nancy.Data
{
	public interface IRecordingRepository
	{
		Recording GetFromDb(int recordingId);
	}
}