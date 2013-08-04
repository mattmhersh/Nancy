using System;
using Microsoft.Owin.Hosting;

namespace KatanaSelfHost
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");

			var url = "http://+:8080";

			using (WebApp.Start<Startup>(url))
			{
				Console.WriteLine("Running on http://localhost:8080", url);
				Console.WriteLine("Press enter to exit");
				Console.ReadLine();
			}

		}
	}
}
