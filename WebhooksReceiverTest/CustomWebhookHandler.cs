using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebhooksReceiverTest
{
	//STEP: 3-Create webhook handler derived from WebhookHandler
	public class CustomWebhookHandler : WebHookHandler
	{
		public override async Task ExecuteAsync(string generator, WebHookHandlerContext context)
		{
			var content = await context.Request.Content.ReadAsStringAsync();
			Trace.WriteLine(string.Format("Generator: {0} - Content: {1}", generator, content));
		}
	}
}