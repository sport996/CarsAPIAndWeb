using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class CarController : Controller
    {
        private readonly IConfiguration _Configure;
        private readonly string apiBaseUrl;
        public CarController(IConfiguration configuration)
        {
            _Configure = configuration;
            apiBaseUrl = _Configure.GetValue<string>("WebBaseUrl");
        }
        public IActionResult Index()
        {
            using HttpClient client = new HttpClient();
            string endpoint = apiBaseUrl + "Car/GetCars";
            var Response = client.GetAsync(endpoint).Result;
            if (Response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<Car>>(Response.Content.ReadAsStringAsync().Result);
                return View(result);
            }
            return View();
        }
    }
}
