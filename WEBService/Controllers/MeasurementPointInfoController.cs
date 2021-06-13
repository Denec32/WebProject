using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBService.Models;

namespace WEBService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementPointInfoController : ControllerBase
    {
        WebServiceDBContext db;

        public MeasurementPointInfoController(WebServiceDBContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<ActionResult<MeasuringPointCombined>> Post(MeasuringPointCombined measuringPointCombined)
        {
            if (measuringPointCombined == null)
            {
                return BadRequest();
            }

            db.ElectricityMeasuringPoints.Add(measuringPointCombined.ElectricityMeasuringPoint);
            db.CurrentTransformers.Add(measuringPointCombined.CurrentTransformer);
            db.PotentialTransformers.Add(measuringPointCombined.PotentialTransformer);
            db.ElectricityMeters.Add(measuringPointCombined.ElectricityMeter);

            await db.SaveChangesAsync();
            return Ok(measuringPointCombined);
        }
    }
}
