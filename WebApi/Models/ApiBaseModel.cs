using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;

namespace WebApi.Models
{
    public class ApiResponseBody
    {
        [IgnoreDataMember]
        public HttpStatusCode HttpStatusCode { get; set; }

        public string Version { get; set; }

        public int ResponseCode { get; set; }

        public string ResponseMessage { get; set; }

        public object Data { get; set; }
    }
}