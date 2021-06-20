using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            List<PointOfUse> pou = _serviceAPI.GetPointOfUse().Result.ToList();

            List<UsageAndMeasuringPointViewModel> vm = new List<UsageAndMeasuringPointViewModel>();
            for (int i = 0; i < pou.Count(); i++)
            {
                vm.Add(new UsageAndMeasuringPointViewModel() { PointOfUse = pou[i]});
            }
            List<ElectricityMeasuringPoint> emp = _serviceAPI.GetElectricityMeasuringPoint().Result.ToList();

            for (int i = 0; i < vm.Count; i++)
            {
                vm[i].ElectricityMeasuringPoint = new List<ElectricityMeasuringPoint>();
                foreach (var item in emp)
                {
                    if (vm[i].PointOfUse.PointOfUseId == item.PointOfUseId)
                    {
                        vm[i].ElectricityMeasuringPoint.Add(item);
                    }
                }
            }
            return View(vm);
        }

        public IActionResult CreateElectricityMeasuringPoint(int? id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult PotentialTransformer(int id)
        {
            List<PotentialTransformer> pt = _serviceAPI
                .GetPotentialTransformer(id).Result.ToList();
            return View(pt);
        }

        public IActionResult CurrentTransformer(int id)
        {
            List<CurrentTransformer> ct = _serviceAPI
               .GetCurrentTransformer(id).Result.ToList();
            return View(ct);
        }

        public IActionResult ElectricityMeter(int id)
        {
            List<ElectricityMeter> em = _serviceAPI
               .GetElectricityMeter(id).Result.ToList();
            return View(em);
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

        public async Task<IEnumerable<PotentialTransformer>> GetPotentialTransformer(int id)
        {
            return await _serviceAPI.GetPotentialTransformer(id);
        }

        public async Task<ActionResult<MeasuringPointCombined>> 
            PostMeasuringPointCombined(MeasuringPointCombined measuringPointCombined)
        {
            return await _serviceAPI.PostMeasuringPointCombined(measuringPointCombined);
        }

        /// <summary>
        /// Описание методад
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PointOfUse>> GetPointOfUse()
        {
            return await _serviceAPI.GetPointOfUse();
        }

        public async Task<IEnumerable<ElectricityMeasuringPoint>> GetElectricityMeasuringPoint()
        {
            return await _serviceAPI.GetElectricityMeasuringPoint();
        }
    }
}
