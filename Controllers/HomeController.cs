using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        [Route("Client/{ClientNo}")]
        public ActionResult GetClient(int ClientNo)
        {
            ViewBag.ClientNo = ClientNo;
            return View();
        }

        [Route("Exchange/{ExNo}")]
        public ActionResult GetExchange(int ExNo)
        {
            ViewBag.ExNo = ExNo;
            return View();
        }

        [Route("Broker/{BrokerNo:int:min(10)}")] // Add Constraint
        public ActionResult GetBroker(int BrokerNo)
        {
            ViewBag.BrokerNo = BrokerNo;
            return View();
        }

    }
}