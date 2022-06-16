using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410828608_Final.Controllers
{
    public class MelodyController : Controller
    {
        // GET: Melody
        public ActionResult Index(string name,float? melody)
        {
            var result = "";
            if(melody==1)
                result="do";
            else if (melody == 2)
                result = "re";
            else if (melody == 3)
                result = "mi";
            else if (melody == 4)
                result = "fa";
            else if (melody == 5)
                result = "so";
            else if (melody == 6)
                result = "la";
            else if (melody == 7)
                result = "xi";
            else 
                result = "錯誤";

            ViewBag.Name = name;
            ViewBag.Result = result;
            return View();
        }
    }
}