using Azure.Storage.Blobs;
using Bcp.Data;
using Bcp.Domain.Models;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Bcp.Api.Services
{
    public class BlobService : IBlobService
    {
        //private readonly BlobServiceClient _blobServiceClient;
        private readonly BlobContainerClient _blobContainerClient;
        private readonly BcpContext _context;

        public BlobService(BlobContainerClient blobContainerClient, BcpContext bcpContext)
        {
            //_blobServiceClient = blobServiceClient;     
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
                    await GetRoutingBlobAsync(blobItem.Name);
                }
                //else if (blobItem.Name.ToLower().Contains("classification"))
                //{
                //    await GetClassificationBlobAsync(blobItem.Name);
                //}
                else if (blobItem.Name.ToLower().Contains("customers"))
                {
                    await GetCustomersBlobAsync(blobItem.Name);
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
    }
}
