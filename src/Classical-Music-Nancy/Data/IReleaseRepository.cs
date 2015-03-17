namespace Classical_Music_Nancy.Data
{
	public interface IReleaseRepository
	{
		Model.Release GetFromDb(int releaseId);
	}
}