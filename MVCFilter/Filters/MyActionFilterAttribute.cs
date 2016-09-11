using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilter.Filters
{
	public class MyActionFilterAttribute:ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			filterContext.HttpContext.Response.Write("<p>action result before<p/>");
			base.OnActionExecuting(filterContext);
		}

		public override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			filterContext.HttpContext.Response.Write("<p>action result after<p/>");
			base.OnActionExecuted(filterContext);
		}
	}
}