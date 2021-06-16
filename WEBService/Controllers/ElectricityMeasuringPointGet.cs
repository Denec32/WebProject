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
    public class ElectricityMeasuringPointGet : ControllerBase
    {
        WebServiceDBContext db;

        public ElectricityMeasuringPointGet(WebServiceDBContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<IEnumerable<ElectricityMeasuringPoint>> Get()
        {
            return await db.ElectricityMeasuringPoints.ToListAsync();
        }
    }
}
