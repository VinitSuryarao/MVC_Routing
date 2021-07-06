using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    [RoutePrefix("Student")]
    public class ClientController : Controller
    {
        // GET: Client
        [Route("")]
        public ActionResult GetStudent()
        {
            return View();
        }

        [Route("{id}")]
        public ActionResult GetStudentData(int id)
        {
            return View();
        }

        [Route("~/AboutUs")]
        public ActionResult GetStudentMarks(int id)
        {
            return View();
        }


    }
}