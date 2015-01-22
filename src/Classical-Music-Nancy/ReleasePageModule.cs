using System;
using System.Linq;
using Nancy;
using Neo4jClient;
using Neo4jClient.Cypher;
using Newtonsoft.Json;

namespace Classical_Music_Nancy
{
    public class ReleasePageModule : NancyModule
    {

        public ReleasePageModule()
        {
            Get["/release/1"] = parameters => RenderReleasePage();
        }

        private static string RenderReleasePage()
        {
            return "{\n\"release_title\": \"Mahler: Symphony No. 1\"\n}";
        }
    }

    // The below should replace the hardcoded return in RenderReleasePage()
    // eventually, but isn't working yet.
    public class Release
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

    }

}
