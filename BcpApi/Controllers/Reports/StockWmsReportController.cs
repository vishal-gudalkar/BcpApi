using Bcp.Api.Services.Stock;
using Bcp.Data;
using Bcp.Domain.Dtos;
using Bcp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace Bcp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockWmsReportController : ControllerBase
    {
        private readonly IStockService _stockService;
        public StockWmsReportController(IStockService stockService, BcpContext bcpContext)
        {
            _stockService = stockService;
        }

        [HttpPost("GetStockWmsReportDetails")]
        public IActionResult GetStockWmsReportDetails(StockWmsSearchDto searchStockWms)
        {
            var data = _stockService.GetExportData();            

            if (!string.IsNullOrEmpty(searchStockWms.Bin))
            {
                data = data.Where(x => x.Bin == searchStockWms.Bin);
            }
            if (!string.IsNullOrEmpty(searchStockWms.LabelNr))
            {
                data = data.Where(x => x.LabelNr == searchStockWms.LabelNr);
            }
            if (!string.IsNullOrEmpty(searchStockWms.RackId))
            {
                data = data.Where(x => x.RackId == searchStockWms.RackId);
            }
            if (!string.IsNullOrEmpty(searchStockWms.MatType))
            {
                data = data.Where(x => x.MatType == searchStockWms.MatType);
            }
            if (!string.IsNullOrEmpty(searchStockWms.Delivery))
            {
                data = data.Where(x => x.Delivery == searchStockWms.Delivery);
            }
            if (!string.IsNullOrEmpty(searchStockWms.BatchNr))
            {
                data = data.Where(x => x.BatchNr == searchStockWms.BatchNr);
            }
            if (!string.IsNullOrEmpty(searchStockWms.SerialNr))
            {
                data = data.Where(x => x.SerialNr == searchStockWms.SerialNr);
            }
            if (!string.IsNullOrEmpty(searchStockWms.SapLoc))
            {
                data = data.Where(x => x.SapLoc == searchStockWms.SapLoc);
            }
            if (!string.IsNullOrEmpty(searchStockWms.ChckQty))
            {
                if (searchStockWms.ChckQty == "N"){
                    data = data.Where(x => x.Qty < 0);
                }
                else if (searchStockWms.ChckQty == "Z"){
                    data = data.Where(x => x.Qty == 0);
                }
                else if (searchStockWms.ChckQty == "P"){
                    data = data.Where(x => x.Qty > 0);
                }
            }
            var result = data.ToList();
            return Ok(result);
        }

        [HttpGet("StockWmsExcelExportData")]
        public IActionResult GetStockWmsExcelExportData()
        {
            var data = _stockService.GetExportData();
            var result = data.ToList();
            return Ok(result);
        }
    }
}
