using Ite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ite.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        PostContext db = new PostContext();

        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public ActionResult About()
        {
            var t = User.Identity.IsAuthenticated;
            var tr = User.IsInRole("admin");
            var tru = User.IsInRole("user");

            ViewBag.Message = "Your application description page.";
            List<State> stateList = db.States.ToList();
            return View();
        }

        [Authorize(Roles = "user")]
        public ActionResult Contact()
        {
            var t = User.Identity.IsAuthenticated;
            var tr = User.IsInRole("admin");
            var tru = User.IsInRole("user");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}