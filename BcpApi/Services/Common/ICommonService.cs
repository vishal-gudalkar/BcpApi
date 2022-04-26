using Bcp.Domain.Dtos;
using Bcp.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Bcp.Api.Services.Common
{
    public interface ICommonService
    {
        Task SaveBinChanges(StockWmsDto binChanges);

    }
}
