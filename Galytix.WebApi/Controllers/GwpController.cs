using CountryGwp;
using Galytix.WebApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Galytix.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class GwpController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("avg")]
        public async Task<IActionResult> avg(GwpInfo gInfo)
        {
            gwpModel gwpModel = new gwpModel(new CountryGwpService());
            return Ok(gwpModel.GetReponse(gInfo.country, gInfo.listOfBusiness));
        }
    }
}
