using Newtonsoft.Json;

namespace Classical_Music_Nancy.Model
{
	public class Release
	{
		[JsonProperty(PropertyName = "name")]
		public string Title { get; set; }

		[JsonProperty(PropertyName = "sd_id")]
		public int SevenDigitalId { get; set; }

		//[JsonProperty(PropertyName = "upc")]
		//public int Upc { get; set; }
	}
}