using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThisorThat.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Browse(string list)
        {

            if(list ==null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.list = list;

            return View();
        }

        public IActionResult Create ()
        {
            return View();
        }
    }
}
