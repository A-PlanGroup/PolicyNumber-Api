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

//namespace SuggestiveService.Services
//{
//    public abstract class SerilogBaseLogger
//    {
//        public bool InfoEnabled { get; }

//        protected SerilogBaseLogger()
//        {
//            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

//            IConfigurationRoot Configuration = builder.Build();
//            string infoEnabled = Configuration["InfoLog"];
//            if (infoEnabled.ToLower() == "true")
//            {
//                InfoEnabled = true;
//            }
//        }

//        public virtual void LogDebug(string message, string activityId)
//        {
//            if (string.IsNullOrEmpty(message) == false && Log.Logger != null)
//            {
//                //Log.Logger.Debug(activityId + ": {Message}", message);
//            }
//        }

//        public virtual void LogDebug(Exception message, string activityId, string customMessage = "")
//        {
//            if (message != null && Log.Logger != null)
//            {
//                Log.Logger.Debug(message, activityId + ": {Message}", customMessage);
//            }
//        }

//        public virtual void LogInformation(string message, string activityId)
//        {
//            if (string.IsNullOrEmpty(message) == false && Log.Logger != null && InfoEnabled)
//            {
//                Log.Logger.Information(activityId + ": {Message}", message);
//            }
//        }

//        public virtual void LogError(string message, string activityId)
//        {
//            if (string.IsNullOrEmpty(message) == false && Log.Logger != null)
//            {
//                Log.Logger.Error(activityId + ": {Message}", message);
//            }
//        }

//        public virtual void LogError(Exception message, string activityId, string customMessage = "")
//        {
//            if (message != null && Log.Logger != null)
//            {
//                Log.Logger.Error(message, activityId + ": {Message}", customMessage);
//            }
//        }
//    }
//}
