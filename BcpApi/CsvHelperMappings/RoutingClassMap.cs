using Bcp.Api.Converters;
using Bcp.Domain.Models;
using CsvHelper.Configuration;
using System.Globalization;

namespace Bcp.Api.CsvHelperMappings
{
    public class RoutingClassMap : ClassMap<Routing>
    {
        public RoutingClassMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.ID).Ignore();
            Map(m => m.Plant).Index(0);
            Map(m => m.ConsolidatedCode).Index(1).TypeConverter(new StringOutputFormatter());
            Map(m => m.Material).Index(2).TypeConverter(new StringOutputFormatter());
            Map(m => m.MaterialType).Index(3);
            Map(m => m.Operation).Index(4);
            Map(m => m.WorkCenter).Index(5);
            Map(m => m.Description).Index(6);
            Map(m => m.Stufe).Index(7);
        }
    }
}
