using Newtonsoft.Json;

namespace Classical_Music_Nancy.Model
{
	public class Release
	{
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }
	}
}