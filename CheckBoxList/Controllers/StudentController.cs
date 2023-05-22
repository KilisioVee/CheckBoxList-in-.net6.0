using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CheckBoxList.Models;
using CheckBoxList.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace CheckBoxList.Controllers
{
    public class StudentController : Controller
    {
        //    
        // GET: /Student/    

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {
            StudentModel objStudentModel = new StudentModel();
            List<SelectListItem> names = new List<SelectListItem>();
            names.Add(new SelectListItem { Text = "Sourabh", Value = "1" });
            names.Add(new SelectListItem { Text = "Surbhee", Value = "2" });
            names.Add(new SelectListItem { Text = "Vinay", Value = "3" });
            names.Add(new SelectListItem { Text = "Tushar", Value = "4" });
            names.Add(new SelectListItem { Text = "Tush", Value = "5" });
            names.Add(new SelectListItem { Text = "Almah", Value = "6" });
            names.Add(new SelectListItem { Text = "Alice", Value = "7" });
            names.Add(new SelectListItem { Text = "Jane", Value = "8" });
            names.Add(new SelectListItem { Text = "Arya", Value = "9" });
            names.Add(new SelectListItem { Text = "Chloe", Value = "10" });
            objStudentModel.StudentNames = names;

            return View(objStudentModel);
        }

        [HttpPost]
        public ActionResult Studentl(string[] Name)
        {
            return Json(new { success = Name });
        }
    }
}