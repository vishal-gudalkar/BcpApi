using AutoMapper;
using Bcp.Data;
using Bcp.Domain.Dtos;
using Bcp.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bcp.Api.Services.Common
{
    public class CommonService : ICommonService
    {
        private readonly BcpContext _context;
        private readonly IMapper _mapper;

        public CommonService(BcpContext bcpContext, IMapper mapper)
        {
            _context = bcpContext;
            _mapper = mapper;
        }

        public async Task SaveBinChanges(StockWmsDto binChanges) 
        {
            try
            {
                if(!string.IsNullOrEmpty(binChanges.LabelNr) && !string.IsNullOrEmpty(binChanges.Bin))
                {
                    var data = (from stockBin in _context.stockwms where stockBin.LabelNr == binChanges.LabelNr select stockBin).FirstOrDefault();
                    if (data != null)
                    {
                        data.Bin = binChanges.Bin;
                        _context.stockwms.Update(data);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {

                    }
                }
                else if (!string.IsNullOrEmpty(binChanges.RackId) && !string.IsNullOrEmpty(binChanges.Bin))
                {
                    var data = (from stockBin in _context.stockwms where stockBin.RackId == binChanges.RackId select stockBin).FirstOrDefault();
                    if (data != null)
                    {
                        data.Bin = binChanges.Bin;
                        _context.stockwms.Update(data);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            catch (Exception ex) 
            {
                
            }
        }

    }
}
