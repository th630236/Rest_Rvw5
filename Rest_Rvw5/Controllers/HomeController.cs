using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rest_Rvw5.Models;

namespace Rest_Rvw5.Controllers
{
  public class HomeController : Controller
  {
    public static ApplicationUser curUser;

        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            if (Request.IsAuthenticated)
            {
                var userId = User.Identity.GetUserId();

                curUser = await HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>().FindByIdAsync(userId);

                //ViewBag.FullName = curUser.FirstName + " " + curUser.LastName;
            }

            return View();  // Gartenkraft commented all but this line in this function. (They had added UserInRole("Admin") etc.) (Tim H Note)
        }

        /*public ActionResult Index()
        {
            return View();
        }*/


        public ActionResult About()  // Gartenkraft commented this function (Tim H Note)
        {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    [Authorize]
    public ActionResult Contact()  // Gartenkraft commented this function (Tim H Note)
        {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}