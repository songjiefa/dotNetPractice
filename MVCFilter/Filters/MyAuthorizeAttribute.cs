using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilter.Filters
{
	public class MyAuthorizeAttribute : AuthorizeAttribute
	{
		public override void OnAuthorization(AuthorizationContext filterContext)
		{
			filterContext.HttpContext.Response.Write("<p>Authorization</p>");
			//base.OnAuthorization(filterContext);
		}
	}
}