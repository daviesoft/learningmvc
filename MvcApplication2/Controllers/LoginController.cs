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

        //POST: /Login/
        [HttpPost]
        public ActionResult Index (AuthLogin form)
        {
            if(!ModelState.IsValid)
            return View();

            if(form.Username !="Test")
            { 
                ModelState.AddModelError("Username", "The username does not exits?");
                return View(form);
            }

            return Url("~/Welcome");
        }

    }
}
