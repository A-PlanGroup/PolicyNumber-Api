//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Extensions.Configuration;
//using Microsoft.WindowsAzure.Storage;
//using Microsoft.WindowsAzure.Storage.Blob;

//namespace SuggestiveService.Services
//{
//    public class StorageService
//    {
//        //string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=arkstoragedevelopment;AccountKey=keTh9FeE4v/a+571nI6H5g+Gn4K4q6ZiKAS3qd90uc85wLVqsugHQE58zYPnXCA+qSGMSV6mX31vEtXqEUuc1Q==;EndpointSuffix=core.windows.net";
//        CloudBlobContainer container;
//        public StorageService()
//        {
//            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
//            IConfigurationRoot Configuration = builder.Build();
//            CloudStorageAccount account = CloudStorageAccount.Parse(Configuration["ConnectionStrings:StorageAccount"]);

//           // CloudStorageAccount account = CloudStorageAccount.Parse(storageConnectionString);
//            CloudBlobClient serviceClient = account.CreateCloudBlobClient();
//            // Create container. Name must be lower case.
//            //Console.WriteLine("Creating container...");
//            container = serviceClient.GetContainerReference("azure-endsliegh-enrichment-logs");
//            container.CreateIfNotExistsAsync().Wait();
//        }
//        public void SaveLogs(StringBuilder logs,string eRef)
//        {
            
//            // write a blob to the container
//            string fileName = eRef + ".txt";
//            //System.IO.File.WriteAllLines(fileName, logs);
//            CloudBlockBlob blob = container.GetBlockBlobReference(fileName);
//            blob.UploadTextAsync(logs.ToString());
//           // blob.UploadFromFileAsync(fileName).Wait();
//        }
//    }
//}
