using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

using WebApi.Models;
using WebApi.Enums;

namespace WebApi.Helpers
{
    public static class CustomApiResponse
    {
        public static ApiResponseBody ConstructOKResponse(object response, string version, string message = null)
        {
            return new ApiResponseBody()
            {
                HttpStatusCode = HttpStatusCode.OK,
                Version = version,
                ResponseCode = (int)HttpStatusCode.OK,
                ResponseMessage = message ?? ApiResponseMessage.OK.GetEnumDescription(),
                Data = response
            };
        }

        public static ApiResponseBody ConstructInternalServerErrorResponse(object response, string version)
        {
            return new ApiResponseBody()
            {
                HttpStatusCode = HttpStatusCode.InternalServerError,
                Version = version,
                ResponseCode = (int)HttpStatusCode.InternalServerError,
                ResponseMessage = ApiResponseMessage.InternalServerError.GetEnumDescription(),
                Data = response
            };
        }
    }
}