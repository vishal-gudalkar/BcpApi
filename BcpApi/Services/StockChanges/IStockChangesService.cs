using System.Threading.Tasks;
using Bcp.Domain.Dtos;

namespace Bcp.Api.Services
{
    public interface IStockChangesService
    {
        Task<int> SaveStatusChanges(StockChangesDto statusChanges);
    }
}
