using Azure.Storage.Blobs;
using Bcp.Data;
using Bcp.Domain.Models;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bcp.Api.Services
{
    public class BlobService : IBlobService
    {
        private readonly BlobContainerClient _blobContainerClient;
        private readonly BcpContext _context;

        public BlobService(BlobContainerClient blobContainerClient, BcpContext bcpContext)
        {
            _blobContainerClient = blobContainerClient;
            _context = bcpContext;
        }
        async Task GetRoutingBlobAsync(string name)
        {
            var blobClient = _blobContainerClient.GetBlobClient(name);
            MemoryStream blobStream = new MemoryStream();
            await blobClient.DownloadToAsync(blobStream);
            blobStream.Position = 0;
            
            var routings = new List<Routing>();
            
            using (var reader = new StreamReader(blobStream)) 
            {
                while (!reader.EndOfStream)
                { 
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    routings.Add(new Routing()
                    {
                        Plant = values[0],
                        ConsolidatedCode = values[1].Replace(values[1].Substring(0, 11), ""),
                        Material = values[2].Replace(values[2].Substring(0, 11), ""),
                        MaterialType = values[3],
                        Operation = values[4],
                        WorkCenter = values[5],
                        Description = values[6],
                        Stufe = Int16.Parse(values[7])
                    });
                }
            }
            //Bulk Insert
            await _context.BulkInsertAsync(routings);
            //string context = new StreamReader(blobStream).ReadToEnd();

            //string filePath = Path.Combine("DownloadedFiles");
            //blobClient.DownloadTo(@"" + filePath + "");            
        }

        public async Task ListBlobAsync()
        {
            await foreach (var blobItem in _blobContainerClient.GetBlobsAsync())
            {
                if (blobItem.Name.ToLower().Contains("routing"))
                {
                    //await GetRoutingBlobAsync(blobItem.Name);
                }
                //else if (blobItem.Name.ToLower().Contains("classification"))
                //{
                //    await GetClassificationBlobAsync(blobItem.Name);
                //}
                else if (blobItem.Name.ToLower().Contains("customers"))
                {
                    //await GetCustomersBlobAsync(blobItem.Name);
                }
                else if (blobItem.Name.ToLower().Contains("stock"))
                {
                    await GetStockBlobAsync(blobItem.Name);
                }
                //items.Add(blobItem.Name);
            }            
        }

        async Task GetCustomersBlobAsync(string name)
        {
            string customerCols = "Customer, SOrg, DChl, Dv, Funct, Customer1, Name1, Name2, Cty, City, PostalCode, Street, IncoT, Inco2, Curr, SGrp, Telephone1, FaxNumber, " +
                                 "TaxNumber1, TaxNumber2, E-MailAddress, CustomerBrand, SiteName, Customerwebsite, IDLogin, IDpassword, " +
                                 "Customercontactemail1, Customercontactemail2, Customercontactemail3, Customeremergencyemail, " +
                                 "Customeradditionaltelephone, Customerlogisticcontactemail, Customertransportwebsite, SGSCustomerservicereferentemail, AcctAtCust";

            var blobClient = _blobContainerClient.GetBlobClient(name);
            MemoryStream blobStream = new MemoryStream();
            await blobClient.DownloadToAsync(blobStream);
            blobStream.Position = 0;
            var customers = new List<customer>();

            using (var reader = new StreamReader(blobStream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    var props = typeof(customer).GetProperties();
                    
                    customers.Add(new customer()
                    {                        
                        //Plant = values[0],
                        //ConsolidatedCode = values[1],
                        //Material = values[2],
                        //MaterialType = values[3],
                        //Operation = values[4],
                        //WorkCenter = values[5],
                        //Description = values[6],
                        //Stufe = Int16.Parse(values[7])
                    });
                }
            }
            //Bulk Insert
            //await _context.BulkInsertAsync(customers);        
        }

        async Task GetClassificationBlobAsync(string name)
        {
            var blobClient = _blobContainerClient.GetBlobClient(name);
            MemoryStream blobStream = new MemoryStream();
            await blobClient.DownloadToAsync(blobStream);
            blobStream.Position = 0;
            
            var classifications = new List<Classification>();

            using (var reader = new StreamReader(blobStream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    classifications.Add(new Classification()
                    {
                        //Plant = values[0],
                        //ConsolidatedCode = values[1],
                        //Material = values[2],
                        //MaterialType = values[3],
                        //Operation = values[4],
                        //WorkCenter = values[5],
                        //Description = values[6],
                        //Stufe = Int16.Parse(values[7])
                    });
                }
            }
            //Bulk Insert
            //await _context.BulkInsertAsync(classifications);                      
        }

        async Task GetStockBlobAsync(string name)
        {
            var blobClient = _blobContainerClient.GetBlobClient(name);
            MemoryStream blobStream = new MemoryStream();
            await blobClient.DownloadToAsync(blobStream);
            blobStream.Position = 0;

            var stocks = new List<StockWms>();

            using (var reader = new StreamReader(blobStream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Contains(";") ? line.Split(';') : line.Split(',');
                    if (values.Count() == 19 && !name.ToLower().Contains("raw"))
                    {
                        stocks.Add(new StockWms()
                        {
                            Bin = "",
                            Product = values[0],
                            ProdAdd = values[1],
                            Plant = values[2],
                            SapLoc = values[3],
                            Qty = !String.IsNullOrEmpty(values[5]) ? Convert.ToInt32(Convert.ToDouble(values[5])) : 0,
                            MatType = values[13],
                            ProdDsc2 = values[14],
                            WareHouse = values[18],
                            Delivery = values[17]
                        });
                    }
                    else if (values.Count() == 39)
                    {
                        if (values[0] != "\"FACILITY\"")
                        {
                            stocks.Add(new StockWms()
                            {
                                Bin = values[6],
                                BinStatus = values[30],
                                CarBrand = values[33],
                                ContentStatus = values[7],
                                DryDate = !string.IsNullOrEmpty(values[13]) ? Convert.ToDateTime(values[13].Substring(1, 4) + "-" + values[13].Substring(5, 2) + "-" + values[13].Substring(7, 2)) : null,
                                ExpDate = !string.IsNullOrEmpty(values[12]) ? Convert.ToDateTime(values[12].Substring(1, 4) + "-" + values[12].Substring(5, 2) + "-" + values[12].Substring(7, 2)) : null,
                                GlassPos = values[31],
                                GlassTyp = values[32],
                                LabelNr = values[2],
                                LabelStatus = values[3],
                                LotNr = values[14],
                                Market = values[9],
                                MatGrp = values[25],
                                MatType = values[4].Replace("10", ""),
                                PackNr = values[15],
                                Product = values[17],
                                ProdAdd = values[5],
                                ProdDsc2 = values[5],
                                //PrNetWeight = !string.IsNullOrEmpty(values[26]) ? Convert.ToDecimal(values[26]) : 0,
                                PrWeightUnit = values[27],
                                Qty = !string.IsNullOrEmpty(values[18]) ? Int32.Parse(values[18]) : 0,
                                RackId = values[10],
                                //RackTotWgt = !string.IsNullOrEmpty(values[28]) ? Convert.ToDecimal(values[28]) : 0,
                                RackType = values[11],
                                ReasonCodeLong = values[8],
                                //RtNetWeight = !string.IsNullOrEmpty(values[20]) ? Convert.ToDecimal(values[20]) : 0,
                                RtWeightUnit = values[21],
                                SapLoc = values[24],
                                //StatusBDate = !string.IsNullOrEmpty(values[22]) ? Convert.ToDateTime(values[22].Substring(1, 4) + "-" + values[22].Substring(5, 2) + "-" + values[22].Substring(7, 2)) : null,
                                //StatusQDate = !string.IsNullOrEmpty(values[23]) ? Convert.ToDateTime(values[23].Substring(1, 4) + "-" + values[23].Substring(5, 2) + "-" + values[23].Substring(7, 2)) : null,
                                WareHouse = values[19],
                                WorkCenter = "",
                                ZoneDsc = values[16],
                                Plant = values[0],
                                Delivery = ""
                            });
                        }
                    }
                    else if (values.Count() == 19 && name.ToLower().Contains("raw")) 
                    {
                        if (values[4] != "PLANT")
                        {
                            stocks.Add(new StockWms()
                            {
                                LabelNr = values[2],
                                Delivery = values[3],
                                Plant = values[5],
                                ZoneDsc = values[6],
                                Bin = values[7],
                                Product = values[8],
                                Qty = !string.IsNullOrEmpty(values[9]) ? Int32.Parse(values[9]) : 0,
                                DryDate = !string.IsNullOrEmpty(values[10]) ? Convert.ToDateTime(values[10].Substring(1, 4) + "-" + values[10].Substring(5, 2) + "-" + values[10].Substring(7, 2)) : null,
                                ContentStatus = values[13],
                                MatType = "STRA",
                                SapLoc = "PROD"
                            });
                        }
                    }
                    else if (values.Count() == 16)
                    {
                        if (values[1] != "COUNTRY_CODE")
                        {
                            stocks.Add(new StockWms()
                            {
                                Plant = values[0],
                                Product = values[2],
                                ProdAdd = values[3],
                                ProdDsc2 = values[3],
                                Delivery = values[4],
                                ZoneDsc = values[6],
                                Bin = values[7],
                                LabelNr = values[8],
                                LabelStatus = values[9],
                                ContentStatus = values[10],
                                Qty = !string.IsNullOrEmpty(values[14]) ? Int32.Parse(values[14]) : 0
                            });
                        }
                    }
                }
            }

            if (_context.stockwms.Count() > 0)
            {
                //Clearing the data before do bulkInsert
                //await _context.TruncateAsync<StockWms>();
            }
            //Bulk Insert
            //await _context.BulkInsertAsync(stocks);
            //string context = new StreamReader(blobStream).ReadToEnd();

            //string filePath = Path.Combine("DownloadedFiles");
            //blobClient.DownloadTo(@"" + filePath + "");            
        }

    }
}
