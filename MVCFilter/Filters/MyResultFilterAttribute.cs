using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilter.Filters
{
	public class MyResultFilterAttribute: ActionFilterAttribute
	{
		public override void OnResultExecuting(ResultExecutingContext filterContext)
		{
			filterContext.HttpContext.Response.Write("<p>before action<p/>");
			base.OnResultExecuting(filterContext);
		}

		public override void OnResultExecuted(ResultExecutedContext filterContext)
		{
			filterContext.HttpContext.Response.Write("<p>after action<p/>");
			base.OnResultExecuted(filterContext);
		}
	}
}