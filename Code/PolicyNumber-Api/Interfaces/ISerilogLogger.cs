//using SuggestiveService.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Threading.Tasks;

//namespace SuggestiveService.Interfaces
//{
//    /// <summary>
//    /// Get the file containing prompts
//    /// </summary>
//    public interface ISerilogLogger
//    {
//        bool InfoEnabled { get; }
//        /// <summary>
//        /// Logs a debug message in the log sink.
//        /// </summary>
//        /// <param name="message">Message to be logged</param>
//        /// <param name="activityId">Id normally web reference</param>
//        void LogDebug(string message, string activityId);

//        /// <summary>
//        /// Logs a debug message in the log sink.
//        /// </summary>
//        /// <param name="message">Exeption message to be logged</param>
//        /// <param name="activityId">Id normally web reference</param>
//        /// <param name="customMessage">Custom message along with exception</param>
//        void LogDebug(Exception message, string activityId, string customMessage = "");

//        /// <summary>
//        /// Logs a information message in the log sink.
//        /// </summary>
//        /// <param name="message">Message to be logged</param>
//        /// <param name="activityId">Id normally web reference</param>
//        void LogInformation(string message, string activityId);

//        /// <summary>
//        /// Logs a error message in the log sink.
//        /// </summary>
//        /// <param name="message">Message to be logged</param>
//        /// <param name="activityId">Id normally web reference</param>
//        void LogError(string message, string activityId);

//        /// <summary>
//        /// Logs a error message in the log sink.
//        /// </summary>
//        /// <param name="message">Exception message to be logged</param>
//        /// <param name="activityId">Id normally web reference</param>
//        /// <param name="customMessage">Custom message along with exception</param>
//        void LogError(Exception message, string activityId, string customMessage = "");
//    }
//}
