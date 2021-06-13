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
    public class PointOfUse4 : ControllerBase
    {
        WebServiceDBContext db;

        public PointOfUse4(WebServiceDBContext context)
        {
            db = context;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<PotentialTransformer>> Get(int id)
        {
            PointOfUse pou = await db.PointsOfUse.FirstOrDefaultAsync(x => x.PointOfUseId == id);
            if (pou == null)
            {
                return null;
            }

            var outdated = from t1 in db.PotentialTransformers
                           join t2 in db.ElectricityMeasuringPoints
                           on t1.ElectricityMeasuringPointId equals t2.ElectricityMeasuringPointId
                           join t3 in db.PointsOfUse on t2.PointOfUseId equals t3.PointOfUseId
                           where t1.CheckDate < DateTime.Now && t3.PointOfUseId == id
                           select t1;

            return outdated;
        }
    }
}
