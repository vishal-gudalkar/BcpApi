using Bcp.Data;
using Bcp.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using Bcp.Domain.Dtos;
using Bcp.Api.Services.Stock;
using System.Threading.Tasks;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bcp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockEntryController : ControllerBase
    {
        private readonly IStockService _stockService;
        public StockEntryController(IStockService stockService)
        { 
            _stockService = stockService;
        }
        
        [HttpGet("GetLabelValue")]
        public IActionResult GetLabelValue()
        {
            try
            {
                var res = _stockService.GetLabel();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("RackTypes")]
        public IActionResult GetRackTypes()
        {
            try
            {
                var data = _stockService.GetRackTypes();
                return Ok(data);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("StorageLocations")]
        public IActionResult GetStorageLocations()
        {
            try
            {
                var data = _stockService.GetStorageLocations();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("SaveStockEntry")]
        public async Task<IActionResult> SaveStockEntry(StockWmsDto stockEntry)
        {            
            if (ModelState.IsValid)
            {
                await _stockService.SaveStock(stockEntry);
            }
            return Ok();
        }
    }
}
