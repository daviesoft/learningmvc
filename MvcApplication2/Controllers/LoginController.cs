using SimpleBlog.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index (AuthLogin form)
        {
            return Content("Hello there " + form.Username +", how are you today?");
        }

    }
}
