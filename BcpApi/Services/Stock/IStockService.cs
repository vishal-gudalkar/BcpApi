using Bcp.Domain.Dtos;
using Bcp.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Bcp.Api.Services.Stock
{
    public interface IStockService
    {
        int GetLabel();
        IQueryable<RackTypes> GetRackTypes();
        IQueryable<StorageLocation> GetStorageLocations();
        Task SaveStock(StockWmsDto stockEntry);
        IQueryable<StockWms> GetExportData();

    }
}
