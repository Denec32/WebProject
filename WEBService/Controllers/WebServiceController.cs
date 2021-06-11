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
            if (!db.Organizations.Any())
            {
                Subsidiary sub1 = new Subsidiary { OrganizationId = 1, Address = "ул. 8 Марта 39А", Name = "Morgan Rails" };
                Subsidiary sub2 = new Subsidiary { OrganizationId = 1, Address = "ул. Куконковых 4", Name = "Morgan Furniture" };

                Organization org1 = new Organization { Name = "Morgan&Co", Address = "Шереметевский проспект 15",
                    Subsidiaries = new List<Subsidiary>()
                };
                org1.Subsidiaries.Add(sub1);
                db.Organizations.Add(org1);

                db.Subsidiaries.AddRange(sub1, sub2);

                db.SaveChanges();
            }
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
