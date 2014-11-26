using Nancy;

namespace Classical_Music_Nancy
{
    public class StatusModule : NancyModule
    {
        public StatusModule()
        {
            Get["/status"] = parameters => "Hello World";
        }
    }
}