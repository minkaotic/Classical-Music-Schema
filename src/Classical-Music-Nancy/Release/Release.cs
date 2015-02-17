using Newtonsoft.Json;

namespace Classical_Music_Nancy.Release
{
	public class Release
	{
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }
	}
}