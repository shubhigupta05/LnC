using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using TomTom_API.Models;

namespace TomTom_API.Controllers
{
    public class API_Call : Controller
    {
        [BindProperty]
        public string Latitude { get; set; }

        [BindProperty]
        public string Longitude { get; set; }

        [BindProperty]
        public string ErrorMessage { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string PlaceName)
        {
            if (!String.IsNullOrEmpty(PlaceName))
            {
                string apiUrl = $"https://api.tomtom.com/search/2/geocode/{PlaceName}.json?key=awu3jSI4fPVnmXXnTTCaeGACqtWcw4FP";
                var webClient = new WebClient();
                var jsonFile = webClient.DownloadString(apiUrl);
                summary_results jsonData = JsonConvert.DeserializeObject<summary_results>(jsonFile);

                if (jsonFile.Contains("position"))
                {
                    Latitude = jsonData.results[1].position.lat.ToString();
                    Longitude = jsonData.results[1].position.lon.ToString();

                    ViewBag.Latitude = $"Latitude: {Latitude}";
                    ViewBag.Longitude = $"Longitude: {Longitude}";
                }
                else
                    ViewBag.ErrorMessage = "Please enter a valid data";
            }
            else
                ViewBag.ErrorMessage = "Please enter place name";
            return View();
        }
    }
}
