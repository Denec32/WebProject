using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBService.Models;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace WEBService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasuringPointCombinedController : ControllerBase
    {
        WebServiceDBContext db;

        public MeasuringPointCombinedController(WebServiceDBContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<ActionResult<MeasuringPointCombined>> Post([FromBody]MeasuringPointCombined measuringPointCombined)
        {
            
            if (measuringPointCombined == null)
            {
                return BadRequest();
            }

            ElectricityMeasuringPoint emp = measuringPointCombined.ElectricityMeasuringPoint;
            db.ElectricityMeasuringPoints.Add(emp);

            await db.SaveChangesAsync();
            
            CurrentTransformer ct = measuringPointCombined.CurrentTransformer;
            ct.ElectricityMeasuringPointId = emp.ID;
            db.CurrentTransformers.Add(ct);

            PotentialTransformer pt = measuringPointCombined.PotentialTransformer;
            pt.ElectricityMeasuringPointId = emp.ID;
            db.PotentialTransformers.Add(pt);

            ElectricityMeter em = measuringPointCombined.ElectricityMeter;
            em.ElectricityMeasuringPointId = emp.ID;
            db.ElectricityMeters.Add(em);

            await db.SaveChangesAsync(); 
            return Ok(measuringPointCombined);
        }
    }
}
