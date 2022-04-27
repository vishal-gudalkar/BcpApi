using Bcp.Domain.Models;
using CsvHelper.Configuration;
using System.Globalization;

namespace Bcp.Api.CsvHelperMappings
{
    public class StocksClassMap : ClassMap<StockWms>
    {
        public StocksClassMap() 
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.Id).Ignore();
            Map(m => m.Bin).Ignore();
            Map(m => m.ContentStatus).Ignore();
            Map(m => m.DryDate).Ignore();
            Map(m => m.ExpDate).Ignore();
            Map(m => m.LabelNr).Ignore();
            Map(m => m.SerialNr).Ignore();
            Map(m => m.BatchNr).Ignore();
            Map(m => m.MatGrp).Ignore();
            Map(m => m.Market).Ignore();
            Map(m => m.PrNetWeight).Ignore();
            Map(m => m.PrWeightUnit).Ignore();
            Map(m => m.RackId).Ignore();
            Map(m => m.RackType).Ignore();
            
            Map(m => m.Product).Index(0);
            Map(m => m.ProdAdd).Index(1);
            Map(m => m.Plant).Index(2);
            Map(m => m.SapLoc).Index(3);
            Map(m => m.Qty).Index(5);
            Map(m => m.MatType).Index(13);
            Map(m => m.ProdDsc2).Index(14);
            Map(m => m.WareHouse).Index(18);
            Map(m => m.Delivery).Index(17);

            //0 is the first column in the csv file
        }
    }
}
