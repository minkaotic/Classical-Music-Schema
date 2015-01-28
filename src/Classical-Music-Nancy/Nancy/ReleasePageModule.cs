using Classical_Music_Nancy.Database;
using Nancy;
using Newtonsoft.Json;

namespace Classical_Music_Nancy
{
    public class ReleasePageModule : NancyModule
    {
        private Release _release;

        public ReleasePageModule()
        {
            Get["/release/1"] = parameters => ReleaseResponse();
        }

        private Release ReleaseResponse()
        {
            return ReleaseData.GetFromDb();
        }
    }


    public class Release
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        
    }

}
