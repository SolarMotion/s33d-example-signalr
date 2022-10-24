using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApi.Models;
using static WebApi.Helpers.CommonExtension;

namespace WebApi.Controllers
{
    public class PublicApiBaseController : ApiController
    {
        internal readonly string _currentTime = GetTime();
        internal ApiResponseBody _apiResponseBody = new ApiResponseBody();
    }
}
