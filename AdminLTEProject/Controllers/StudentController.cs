using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTEProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentsList()
        {
            return View();
        }

        public ActionResult StudentInfo()
        {
            return View();
        }
    }
}