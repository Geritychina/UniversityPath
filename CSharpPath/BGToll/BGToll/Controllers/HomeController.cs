using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BGToll.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BGToll(string id)
        {
            var url = "https://check.bgtoll.bg/check/vignette/plate/BG/"+id;
            var client = new WebClient();
            var body = "";
            if (id != null && id != "")
            {
                body = client.DownloadString(url);
                JObject data = JObject.Parse(body);


                if ((bool)data["ok"])
                {
                    ViewData["country"] = (string)data["vignette"]["country"];
                    ViewData["vignetteNumber"] = (string)data["vignette"]["vignetteNumber"];
                    ViewData["validityDateFrom"] = (string)data["vignette"]["validityDateFromFormated"];
                    ViewData["validityDateTo"] = (string)data["vignette"]["validityDateToBeFormated"];
                }


                ViewData["body"] = body;
            }
            return View();
        }
    }
}