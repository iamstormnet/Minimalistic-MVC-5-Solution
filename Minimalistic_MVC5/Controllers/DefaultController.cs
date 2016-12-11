using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minimalistic_MVC5.Controllers
{
    public class DefaultController : Controller
    {
        //
        // http://localhost:63646/index
        [Route("index")]
        public ActionResult Index()
        {
            return View();
            //return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Hello
        [Route("hi/{key?}")]
        public string Hello(string key)
        {
            return "This is my <b>Hello</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return HttpUtility.HtmlEncode("Welcome!");
        }
    }
}