using Nancy;

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
}