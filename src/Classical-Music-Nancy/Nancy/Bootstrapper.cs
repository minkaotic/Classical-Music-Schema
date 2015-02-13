using Nancy;
using Nancy.Bootstrapper;
using Nancy.Responses.Negotiation;

namespace Classical_Music_Nancy.Nancy
{
	public class Bootstrapper : DefaultNancyBootstrapper
	{
		protected override NancyInternalConfiguration InternalConfiguration
		{
			get
			{
				return NancyInternalConfiguration.WithOverrides((c) =>
				{
					c.ResponseProcessors.Clear();
					//c.ResponseProcessors.Insert(c.ResponseProcessors.Count, typeof(XmlProcessor));
					c.ResponseProcessors.Insert(c.ResponseProcessors.Count, typeof(JsonProcessor));

				});
			}
		}
	}
}