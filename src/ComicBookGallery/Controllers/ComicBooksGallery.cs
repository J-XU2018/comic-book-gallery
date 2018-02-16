using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.Str = "Detail Page";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>description bababablabal</p>";
            ViewBag.Artists = new string[]
            {
                "script Don Slott",
                "Pencils Humberto Ramos"
            }; 
            return View();
        }
    }
}
