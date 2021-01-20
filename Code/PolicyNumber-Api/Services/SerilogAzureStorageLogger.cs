//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Extensions.Configuration;
//using Microsoft.WindowsAzure.Storage;
//using Microsoft.WindowsAzure.Storage.Blob;
//using Serilog;
//using SuggestiveService.Interfaces;


//namespace SuggestiveService.Services
//{
//    public class SerilogAzureStorageLogger : SerilogBaseLogger, ISerilogLogger
//    {
//        public SerilogAzureStorageLogger() : base()
//        {
//            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

//            IConfigurationRoot Configuration = builder.Build();
//            string storageAccount=Configuration["ConnectionStrings:StorageAccount"];
//            string tableName = "enrichmentapi"+DateTime.Now.ToString("MMM");
//            string infoEnabled= Configuration["ConnectionStrings:InfoLog"]; 

//            if (string.IsNullOrEmpty(tableName))
//            {
//                tableName = $"SerilogTableLogger{DateTime.Today.ToLongDateString()}";
//            }

//            Log.Logger = new LoggerConfiguration()
//                .Enrich.FromLogContext()
//                .WriteTo.AzureTableStorageWithProperties(storageAccount, storageTableName: tableName, writeInBatches: true, batchPostingLimit: 100, period: new System.TimeSpan(0, 0, 3))
//                .CreateLogger();
//        }
//    }
//}
