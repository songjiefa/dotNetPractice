using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilter.Controllers
{
    public class FileterController : Controller
    {
        // GET: Fileter
		[Filters.MyActionFilter]
		[Filters.MyResultFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}