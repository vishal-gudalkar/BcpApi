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
        private readonly BcpContext _context;
        public StockWmsReportController(BcpContext context)
        {
            _context = context;
        }
        [HttpPost("GetStockWmsReportDetails")]
        public IActionResult GetStockWmsReportDetails([FromBody]  StockWmsSearchDto searchStockWms)
        {
            var data = GetExportData();
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
            var data = GetExportData();
            var result = data.ToList();
            return Ok(result);
        }
       private IQueryable<StockWms> GetExportData()
        {
            var data = (from stwms in _context.stockwms
                        join cls in _context.classifications on stwms.Product equals cls.Material
                        into clsTemp
                        from stCls in clsTemp.DefaultIfEmpty()
                        join slm in _context.saplocmarket on stwms.SapLoc equals slm.SapLoc
                        into slmTemp
                        from stSlm in slmTemp.DefaultIfEmpty()
                        select new StockWms
                        {
                           DryDate= stwms.DryDate,
                            MatType= stwms.MatType,
                            Bin= stwms.Bin,
                            ContentStatus=stwms.ContentStatus,
                            LabelNr=stwms.LabelNr,
                            Product=stwms.Product,
                            PrNetWeight= stwms.PrNetWeight,
                            PrWeightUnit=stwms.PrWeightUnit,
                            Qty=stwms.Qty,
                            RackType=stwms.RackType,
                            RackId=stwms.RackId,
                            SapLoc=stwms.SapLoc,
                            Plant=stwms.Plant,
                            Delivery=stwms.Delivery,
                            ProdAdd=stwms.ProdAdd,
                            ProdDsc2=stwms.ProdDsc2,
                            SerialNr=stwms.SerialNr,
                            BatchNr=stwms.BatchNr,
                            MatGrp = stCls.MaterialNumber,
                            Market = stSlm.Market
                        }).AsQueryable();
            return data;
        }
    }
}
