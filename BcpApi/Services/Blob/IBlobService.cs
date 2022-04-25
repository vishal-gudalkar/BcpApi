using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bcp.Api.Services
{
    public interface IBlobService
    {
        public Task ListBlobAsync();
    }
}
