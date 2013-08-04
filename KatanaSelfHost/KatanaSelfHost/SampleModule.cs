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

