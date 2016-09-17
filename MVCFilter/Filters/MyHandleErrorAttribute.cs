using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilter.Filters
{
	public class MyHandleErrorAttribute: HandleErrorAttribute
	{
		public override void OnException(ExceptionContext filterContext)
		{
			//1. get exception
			Exception ex = filterContext.Exception;

			//2. log

			//3. redirect friendly page to show error
			filterContext.Result = new RedirectResult("~/error.html");

			filterContext.ExceptionHandled = true;

			base.OnException(filterContext);
		}
	}
}