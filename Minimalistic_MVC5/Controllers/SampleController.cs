using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minimalistic_MVC5.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        [Route("sample/index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}