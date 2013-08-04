/// <summary>
/// Nancy Documentation
/// https://github.com/NancyFx/Nancy/wiki/Defining-routes
/// </summary>

using System;
using Nancy;

namespace KatanaSelfHost
{
	public class SampleModule : NancyModule
	{
		public SampleModule ()
		{
			Get["/Sample"] = _ => "Hello World!";
		}
	}
}

