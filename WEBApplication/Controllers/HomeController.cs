using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WEBApplication.Models;
using WEBService.Models;

namespace WEBApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWEBServiceAPI _serviceAPI;


 
        public HomeController(ILogger<HomeController> logger, IWEBServiceAPI api)
        {
            _logger = logger;
            _serviceAPI = api;
        }

        public IActionResult Index()
        {
            ViewData["Count"] = GetPointOfUse().Result.ToList().Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IEnumerable<CurrentTransformer>> GetCurrentTransformer(int id)
        {
            return await _serviceAPI.GetCurrentTransformer(id);
        }

        public async Task<IEnumerable<ElectricityMeter>> GetElectricityMeter(int id)
        {
            return await _serviceAPI.GetElectricityMeter(id);
        }

        public async Task<IEnumerable<PotentialTransformer>>GetPotentialTransformer (int id)
        {
            return await _serviceAPI.GetPotentialTransformer(id);
        }

        public async Task<ActionResult<MeasuringPointCombined>> PostMeasuringPointCombined(MeasuringPointCombined measuringPointCombined)
        {
            return await _serviceAPI.PostMeasuringPointCombined(measuringPointCombined);
        }

        public async Task<IEnumerable<PointOfUse>> GetPointOfUse()
        {
            return await _serviceAPI.GetPointOfUse();
        }
    }

}
