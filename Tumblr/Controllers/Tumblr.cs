using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Tumblr_API.Models;

namespace Tumblr_API.Controllers
{
    public class Tumblr : Controller
    {
        public IActionResult Index()
        {
            var webClient = new WebClient();
            string startupPath = Environment.CurrentDirectory;
            var jsonFile = webClient.DownloadString(startupPath + @"\wwwroot\lib\API\Version1.json");
            var jsonData = JsonConvert.DeserializeObject<Tumblr_Detail>(jsonFile);
            return View(jsonData);
        }
    }
}
