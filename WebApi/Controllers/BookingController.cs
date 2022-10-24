using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using static WebApi.Helpers.WebApiLogging;
using WebApi.Models;
using WebApi.BALs;
using static WebApi.Helpers.CustomHttpResult;

namespace WebApi.Controllers
{
    public class BookingController : PublicApiBaseController
    {
        private const string _baseUrl = "api";
        private BookingBAL _bookingBAL = new BookingBAL();

        [Route(_baseUrl + "/Status/{Floor}")]
        [HttpGet]
        public HttpResponseMessage Status([FromUri]StatusRequest request)
        {
            PublicApiStart(nameof(BookingController), nameof(Status), _currentTime, request);

            _apiResponseBody = _bookingBAL.Status(request);

            PublicApiEnd(nameof(BookingController), nameof(Status), _currentTime, _apiResponseBody);

            return Request.ConstructHttpResult(_apiResponseBody);
        }

        [Route(_baseUrl + "/booking/{Floor}")]
        [HttpPost]
        public HttpResponseMessage Booking([FromUri]BookingRequest request)
        {
            PublicApiStart(nameof(BookingController), nameof(Booking), _currentTime, request);

            _apiResponseBody = _bookingBAL.Booking(request);

            PublicApiEnd(nameof(BookingController), nameof(Booking), _currentTime, _apiResponseBody);

            return Request.ConstructHttpResult(_apiResponseBody);
        }

        [Route(_baseUrl + "/newbooking")]
        [HttpPost]
        public HttpResponseMessage NewBooking([FromBody]NewBookingRequest request)
        {
            PublicApiStart(nameof(BookingController), nameof(NewBooking), _currentTime, request);

            _apiResponseBody = _bookingBAL.NewBooking(request);

            PublicApiEnd(nameof(BookingController), nameof(NewBooking), _currentTime, _apiResponseBody);

            return Request.ConstructHttpResult(_apiResponseBody);
        }
    }
}
