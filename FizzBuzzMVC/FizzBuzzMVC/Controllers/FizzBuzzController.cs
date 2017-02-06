using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index(int id)
        {
            for(int i = 1; i <= id; i++) {
                if (id == 1)
                {
                    ViewBag.Output += "1";
                }
                else if (i % 5 == 0)
                {
                    ViewBag.Output += "Buzz ";
                }
                else if (i% 3 == 0)
                {
                    ViewBag.Output += "Fizz ";
                }
                else
                {
                    ViewBag.Output += i.ToString() + " ";
                }
            }
            return View();
        }
    }
}