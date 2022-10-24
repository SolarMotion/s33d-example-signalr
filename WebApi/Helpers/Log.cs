using log4net;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;

using static WebApi.Helpers.CommonExtension;

namespace WebApi.Helpers
{
    public static class Log
    {
        private static readonly ILog _publicLogger = LogManager.GetLogger("PublicApiLogger");
        private static readonly ILog _hubLogger = LogManager.GetLogger("HubLogger");

        #region Public Log

        internal static void PublicInfo(string message)
        {
            _publicLogger.Info(message);
        }

        internal static void PublicError(Exception ex)
        {
            try
            {
                var exString = "";

                if (ex is DbEntityValidationException)
                    exString = (ex as DbEntityValidationException).DbEntityValidationExceptionToString();
                else
                    exString = ex.ToString();

                _publicLogger.Error(exString);
            }
            catch (Exception iex)
            {
                using (var eventLog = new EventLog("Application"))
                {
                    eventLog.WriteEntry(iex.ToString(), EventLogEntryType.Error);
                }
            }
        }

        #endregion

        #region Hub Log

        internal static void HubInfo(string message)
        {
            _hubLogger.Info(message);
        }

        internal static void HubError(Exception ex)
        {
            try
            {
                var exString = "";

                if (ex is DbEntityValidationException)
                    exString = (ex as DbEntityValidationException).DbEntityValidationExceptionToString();
                else
                    exString = ex.ToString();

                _hubLogger.Error(exString);
            }
            catch (Exception iex)
            {
                using (var eventLog = new EventLog("Application"))
                {
                    eventLog.WriteEntry(iex.ToString(), EventLogEntryType.Error);
                }
            }
        }

        #endregion
    }
}