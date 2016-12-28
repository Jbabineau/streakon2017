using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Streakon.Web.Controllers
{
    public class HighscoreController : Controller
    {
        //
        // GET: /HighScore/
        public ActionResult Index()
        {
            //var vm = new HighScoreViewModel();
            return View();
        }
	}
}