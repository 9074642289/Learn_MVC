using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFirstApp.Models;

namespace MvcFirstApp.Controllers
{
    public class numController : Controller
    {
        //
        // GET: /num/

        public ActionResult opt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult opt(Numeric model, string command)
        {
            if (command == "add")
            {
                model.Result = model.A + model.B;
            }
            if (command == "sub")
            {
                model.Result = model.A - model.B;
            }
            if (command == "mul")
            {
                model.Result = model.A * model.B;
            }
            if (command == "div")
            {
                model.Result = model.A / model.B;
            }
            return View(model);
        }

    }
}
