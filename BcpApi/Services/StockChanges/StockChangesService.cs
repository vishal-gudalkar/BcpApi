
using System.Threading.Tasks;
using Bcp.Domain.Dtos;
using Bcp.Data;
using System.Linq;
using Bcp.Api.Enum;
using Bcp.Domain.Models;
using System;

namespace Bcp.Api.Services
{
    public class StockChangesService: IStockChangesService
    {
        private readonly BcpContext _context;

        public StockChangesService(BcpContext bcpContext)
        {
            _context = bcpContext;
        }
        public async Task<int> SaveStatusChanges(StockChangesDto statusChanges)
        {
            StockWms data = null;
            if (!string.IsNullOrEmpty(statusChanges.LabelNr))
            {
                data = _context.stockwms.Where(s => s.LabelNr == statusChanges.LabelNr).FirstOrDefault();
            }
            if (data == null && !string.IsNullOrEmpty(statusChanges.RackId))
            {
                data = _context.stockwms.Where(s => s.RackId == statusChanges.RackId).FirstOrDefault();
            }
            if (data != null)
            {
                bool isSave = false;
                if (statusChanges.FeildChangeType == (int)StockChangesEnum.Bin)
                {
                    data.Bin = statusChanges.Bin;
                    isSave = true;
                }
                else if (statusChanges.FeildChangeType == (int)StockChangesEnum.Status)
                {
                    data.ContentStatus = statusChanges.Status;
                    isSave = true;
                }
                else if (statusChanges.FeildChangeType == (int)StockChangesEnum.Storage)
                {
                    data.SapLoc = statusChanges.SapLoc;
                    isSave = true;
                }
                if (isSave)
                {
                    _context.stockwms.Update(data);
                    await _context.SaveChangesAsync();
                    return (int)ResultEnum.Success;
                }
            }
           
            return (int)ResultEnum.NotFound;
           
        }
    }
}
