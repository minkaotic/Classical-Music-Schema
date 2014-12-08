using Nancy;

namespace Classical_Music_Nancy
{
    public class StatusModule : NancyModule
    {
        public StatusModule()
        {
            Get["/status"] = parameters => HelloWorld();
        }

        private static string HelloWorld()
        {
            return "Hello World";
        }
    }
}