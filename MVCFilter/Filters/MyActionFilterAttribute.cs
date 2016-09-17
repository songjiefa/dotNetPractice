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
			if (filterContext.ActionDescriptor.IsDefined(typeof(Filters.SkiptAttribute), false))
			{
				filterContext.Result = new ContentResult();
			}
			filterContext.HttpContext.Response.Write("<p>before action<p/>");
			base.OnActionExecuting(filterContext);
		}

		public override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			filterContext.HttpContext.Response.Write("<p>after action<p/>");
			base.OnActionExecuted(filterContext);
		}
	}
}