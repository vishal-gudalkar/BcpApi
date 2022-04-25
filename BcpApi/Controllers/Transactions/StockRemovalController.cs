using Bcp.Data;
using Bcp.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using Bcp.Domain.Dtos;
using System.Linq;
using Bcp.Api.Services.Stock;
using System.Threading.Tasks;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bcp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockRemovalController : ControllerBase
    {
        private readonly IStockService _stockService;
        public StockRemovalController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpPost("SaveUpdateStockRemoval")]
        public async Task<IActionResult> SaveUpdateStockRemoval(StockWmsDto stockRemoval)
        {
            if (ModelState.IsValid)
            {
                await _stockService.SaveStockRemoval(stockRemoval);
            }
            return Ok();
        }
    }
}
