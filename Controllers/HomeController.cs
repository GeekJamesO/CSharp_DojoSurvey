using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

		// GET: /Home/
		[HttpPost]
		[Route("result")]
		public IActionResult Result(string yourName, string dojoLocation, string favLanguage, string comment)
		{
            ViewBag.Name = yourName;
            ViewBag.DojoLocation = dojoLocation;
            ViewBag.favLanguage = favLanguage;
            ViewBag.Comment = comment;
			return View();
		}

	}
}
