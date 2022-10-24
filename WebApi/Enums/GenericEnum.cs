using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApi.Enums
{
    public enum ApiVersion
    {
        [Description("1.0.0")]
        One,

        [Description("2.0.0")]
        Two
    }

    public enum ApiResponseMessage
    {
        [Description("Success.")]
        OK,

        [Description("Success.")]
        Created,

        [Description("Success.")]
        Accepted,

        [Description("Oops! Value pass in is incorrect.")]
        BadRequest,

        [Description("API under construction. Please come back later.")]
        NotImplemented,

        [Description("API under maintenance. Please come back later.")]
        ServiceUnavailable,

        [Description("The request is not authorized. Please contact us.")]
        Unauthorized,

        [Description("Oops! Something went wrong. Please contact us.")]
        InternalServerError
    }
}