using System;
using Owin;

namespace KatanaSelfHost
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseNancy(); 
		}
	}
}

