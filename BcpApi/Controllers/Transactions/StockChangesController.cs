using Microsoft.AspNetCore.Mvc;

using Bcp.Domain.Dtos;
using Bcp.Api.Services;
using System.Threading.Tasks;
using Bcp.Api.Enum;
using Microsoft.AspNetCore.Authorization;

namespace Bcp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class StockChangesController : ControllerBase
    {
        private readonly IStockChangesService _commonService;
        public StockChangesController(IStockChangesService commonService)
        {
            _commonService = commonService;
        }


        [HttpPost("update")]
        public async Task<IActionResult> SaveStatusChanges(StockChangesDto changedto)
        {
           var result =await _commonService.SaveStatusChanges(changedto);
            return Ok(result);
        }
    }
}
