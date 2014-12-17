using Nancy;

namespace Classical_Music_Nancy
{
    public class ReleaseInfoModule : NancyModule
    {

        public ReleaseInfoModule()
        {
            Get["/release/1"] = parameters => @"""release_title"": ""Mahler: Symphony No. 1""";
        }
        
    }
}