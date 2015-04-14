using Newtonsoft.Json;

namespace Classical_Music_Nancy.Model
{
	public class Release
	{
		[JsonProperty(PropertyName = "name")]
		public string Title { get; set; }

		[JsonProperty(PropertyName = "release_date")]
		public string ReleaseDate { get; set; }

		[JsonProperty(PropertyName = "upc")]
		public string Upc { get; set; }

		[JsonProperty(PropertyName = "sd_id")]
		public int SevenDigitalId { get; set; }
	}
}