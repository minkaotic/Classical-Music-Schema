using Nancy;

namespace Classical_Music_Nancy.Release
{
	public class ExampleModule : NancyModule
	{
		public ExampleModule()
		{
			Get["/example/{id:int}"] = parameters =>
			{
				var release = new Model.Release()
				{
					Title = parameters.id,
				};

				return Negotiate
					.WithModel(release);
			};
		}
	}
}