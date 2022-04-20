using Bcp.Data;
using Bcp.Domain.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Bcp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockWmsReportController : ControllerBase
    {
        private readonly BcpContext _context;
        public StockWmsReportController(BcpContext context)
        {
            _context = context;
        }
        [HttpPost("GetStockWmsReportDetails")]
        public IActionResult GetStockWmsReportDetails([FromBody]  StockWmsSearchDto searchStockWms)
        {
            var data = (from stwms in _context.stockwms
                              join cls in _context.classifications on stwms.Product equals cls.Material
                              into clsTemp
                              from stCls in clsTemp.DefaultIfEmpty()
                              join slm in _context.saplocmarket on stwms.SapLoc equals slm.SapLoc
                              into slmTemp
                              from stSlm in slmTemp.DefaultIfEmpty()
                              select new
                              {
                                  stwms.DryDate,
                                  stwms.MatType,
                                  stwms.Bin,
                                  stwms.ContentStatus,
                                  stwms.LabelNr,
                                  StockMarket = stwms.Market,
                                  stwms.Product,
                                  stwms.PrNetWeight,
                                  stwms.PrWeightUnit,
                                  stwms.Qty,
                                  stwms.RackType,
                                  stwms.RackId,
                                  stwms.SapLoc,
                                  stwms.Plant,
                                  stwms.Delivery,
                                  stwms.ProdAdd,
                                  stwms.ProdDsc2,
                                  stwms.SerialNr,
                                  stwms.BatchNr,
                                  stCls.MaterialNumber,
                                  Market = stSlm.Market
                              }).AsQueryable();
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
    }
}
