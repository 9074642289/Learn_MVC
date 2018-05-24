using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFirstApp.Models;

namespace MvcFirstApp.Controllers
{
    public class FirstController : Controller
    {
        //
        // GET: /First/

       


        public ActionResult First()
        {

            List<Employe_list> employelist = new List<Employe_list>();
            //Employe_list emp = new Employe_list();

            employelist.Add(new Employe_list { id = 1, Name = "Pradeep", Address = "Marimata" });
            employelist.Add(new Employe_list { id = 2, Name = "Hemant", Address = "LIG" });
            employelist.Add(new Employe_list { id = 3, Name = "Ritesh", Address = "Vijay Nagar" });
            employelist.Add(new Employe_list { id = 4, Name = "Mahesh", Address = "Dewas" });

            //ViewBag.AA=employelist;
            return View(employelist);
            
        }

        // public ActionResult DB_Connect()
        //{
        //    vvvEntities db = new vvvEntities();
        //    List<reg> emp = db.regs.ToList();


        //    retrive_data get_info = new retrive_data();
        //    List<FirstMod> emplist = emp.Select(x => new FirstMod
        //    {
        //        ID = x.ID,
        //        Name = x.Name,
        //        L_Name = x.L_Name,
        //        City = x.City
        //    }).ToList();

        //    return View(emplist);
        // }

    }
}
