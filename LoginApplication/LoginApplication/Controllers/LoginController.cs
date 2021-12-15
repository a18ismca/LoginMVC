using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginApplication.Models;

namespace LoginApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login AND its view baby
        public ActionResult LoginView()
        {
            var account = new Login() { Name = "Govno", Id = 100 };
            return View(account);
        }
    }
}