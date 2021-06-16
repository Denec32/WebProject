﻿using Microsoft.AspNetCore.Http;
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
    public class PointOfUseGetController : ControllerBase
    {
        WebServiceDBContext db;
        public PointOfUseGetController(WebServiceDBContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PointOfUse>>> Get()
        {
            return await db.PointsOfUse.ToListAsync();
        }

    }
}
