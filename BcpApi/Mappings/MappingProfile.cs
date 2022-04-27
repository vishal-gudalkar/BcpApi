using AutoMapper;
using Bcp.Domain.Dtos;
using Bcp.Domain.Models;

namespace Bcp.Api.Mappings
{
   public class MappingProfile : Profile
   {
       public MappingProfile()
       {
           CreateMap<StockWmsDto, StockWms>();
           CreateMap<StockWmsDto, StockMovements>();
        }
   }
}
