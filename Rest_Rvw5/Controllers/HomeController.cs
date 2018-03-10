using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rest_Rvw5.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();  // Gartenkraft commented all but this line in this function. (They had added UserInRole("Admin") etc.) (Tim H Note)
    }

    public ActionResult About()  // Gartenkraft commented this function (Tim H Note)
        {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()  // Gartenkraft commented this function (Tim H Note)
        {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}