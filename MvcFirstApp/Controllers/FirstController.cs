﻿using System;
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


        public ActionResult Get_Details()
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

        [HttpPost]
        public ActionResult allbtn(string save, string draft, string cancel)
        {
            if (!string.IsNullOrEmpty(save))
                return aa();
            else if (!string.IsNullOrEmpty(draft))
                return bb();
            else
                return cc();
        }

        public ActionResult aa()
        {
            ViewBag.Msg = "Details Save successfully.";
            return View();
        }
        public ActionResult bb()
        {
            ViewBag.Msg = "Details Draft successfully.";
            return View();
        }

        public ActionResult cc()
        {
            ViewBag.Msg = "Details cancel successfully.";
            return View();
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


        //[HttpPost]
        //public ActionResult edit(Employe_list empModel)
        //{
        //    ViewBag.Msg = "Details Save successfully.";
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult edit_submit(Employe_list empModel)
        //{
        //    ViewBag.Msg = "Details Save successfully.";
        //    return View();
        //}

    }
}
