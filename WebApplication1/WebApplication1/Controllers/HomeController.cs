using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<MockData> dataObjects = new List<MockData>();



            dataObjects.Add(new MockData()

            {

                Object = "DO",

                Condition = "<",

                Value = 30

            });

            dataObjects.Add(new MockData()

            {

                Object = "DO",

                Condition = ">",

                Value = 30

            });

            return View(dataObjects);
        }

        [HttpPost]
        public ActionResult Index(MockData md)
        {
            return View(md);
        }
    }
}