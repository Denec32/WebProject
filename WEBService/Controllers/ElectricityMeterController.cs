using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBService.Models;

namespace WEBService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricityMeterController : ControllerBase
    {
        WebServiceDBContext db;

        public ElectricityMeterController(WebServiceDBContext context)
        {
            db = context;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<ElectricityMeter>> Get(int id)
        {
            PointOfUse pou = await db.PointsOfUse.FirstOrDefaultAsync(x => x.ID == id);
            if (pou == null)
            {
                return null;
            }

            var outdated = from t1 in db.ElectricityMeters
                           join t2 in db.ElectricityMeasuringPoints
                           on t1.ElectricityMeasuringPointId equals t2.ID
                           join t3 in db.PointsOfUse on t2.PointOfUseId equals t3.ID
                           where t1.CheckDate < DateTime.Now && t3.ID == id
                           select t1;

            return outdated;
        }
    }
}
