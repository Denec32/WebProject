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
    [ApiController]
    [Route("api/orgs")]
    public class WebServiceController : ControllerBase
    {
        WebServiceDBContext db;

        public WebServiceController(WebServiceDBContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organization>>> Get()
        {
            return await db.Organizations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Organization>>> Get(int id)
        {
            Organization org = await db.Organizations.FirstOrDefaultAsync(x => x.OrganizationId == id);
            if (org == null)
            {
                return NotFound();
            }
            return new ObjectResult(org);
        
        }


    }


}
