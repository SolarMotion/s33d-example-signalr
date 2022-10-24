using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using static WebApi.Helpers.Log;

namespace WebApi.Helpers
{
    public static class WebApiLogging
    {
        #region Public Api

        internal static void PublicApiStart(string controller, string function, string datetime)
        {
            PublicInfo($"<-----Start-{datetime}----->");

            PublicInfo($"Entering {controller} > {function}() API...");

            PublicInfo($"Request Value: -");
        }

        internal static void PublicApiStart(string controller, string function, string datetime, object @object)
        {
            PublicInfo($"<-----Start-{datetime}----->");

            PublicInfo($"Entering {controller} > {function}() API...");

            PublicInfo($"Request JSON: {@object.ToJson()}");
        }

        internal static void PublicApiStart(string controller, string function, string datetime, string value = null)
        {
            PublicInfo($"<-----Start-{datetime}----->");

            PublicInfo($"Entering {controller} > {function}() API...");

            PublicInfo($"Request Value: {value ?? "-"}");
        }

        internal static void PublicApiFullRequestBody(string rawBody)
        {
            PublicInfo($"Raw Body: {rawBody}");
        }

        internal static void PublicApiBasicAuth(string datetime, object @object)
        {
            PublicInfo($"<----- Start Basic Auth-{datetime}----->");

            PublicInfo($"Response JSON: {@object.ToJson()}");

            PublicInfo($"<-----End Basic Auth-{datetime}----->");
        }

        internal static void PublicApiEnd(string controller, string function, string datetime, object @object)
        {
            PublicInfo($"Response JSON: {@object.ToJson()}");

            PublicInfo($"Exiting {controller} > {function}() API...");

            PublicInfo($"<------End-{datetime}------>");
        }

        internal static void PublicApiEnd(string controller, string function, string datetime, string stringResult)
        {
            PublicInfo($"Response string: {stringResult}");

            PublicInfo($"Exiting {controller} > {function}() API...");

            PublicInfo($"<------End-{datetime}------>");
        }

        #endregion
    }
}