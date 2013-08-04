using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using Nancy;
using Nancy.Owin;

namespace KatanaSelfHost
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{

			Get["/"] = x => {
				var env                 = (IDictionary<string, object>)Context.Items[NancyOwinHost.RequestEnvironmentKey];

				var requestBody         = (Stream)env["owin.RequestBody"];
				var requestHeaders      = (IDictionary<string, string[]>)env["owin.RequestHeaders"];
				var requestMethod       = (string)env["owin.RequestMethod"];
				var requestPath         = (string)env["owin.RequestPath"];
				var requestPathBase     = (string)env["owin.RequestPathBase"];
				var requestProtocol     = (string)env["owin.RequestProtocol"];
				var requestQueryString  = (string)env["owin.RequestQueryString"];
				var requestScheme       = (string)env["owin.RequestScheme"];

				var responseBody        = (Stream)env["owin.ResponseBody"];
				var responseHeaders     = (IDictionary<string, string[]>)env["owin.ResponseHeaders"];

				var owinVersion         = (string)env["owin.Version"];
				var cancellationToken   = (CancellationToken)env["owin.CallCancelled"];

				var uri = (string)env["owin.RequestScheme"] + "://" + requestHeaders["Host"].First() +
				(string)env["owin.RequestPathBase"] + (string)env["owin.RequestPath"];

				if (env["owin.RequestQueryString"] != "")
				uri += "?" + (string)env["owin.RequestQueryString"];

				return string.Format("{0} {1}", requestMethod, uri);
			};
		}
	}
}

