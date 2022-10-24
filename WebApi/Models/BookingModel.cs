using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApi.Hubs;
using static WebApi.Hubs.BookingHub;

namespace WebApi.Models
{
    #region Status

    public class StatusRequest
    {
        public int Floor { get; set; }
    }

    public class StatusResponse
    {
        public string Status { get; set; }
    }

    #endregion

    #region Booking

    public class BookingRequest
    {
        public int Floor { get; set; }
    }

    public class BookingResponse
    {
        public List<RowItem> Rows { get; set; } = new List<RowItem>();
    }

    public class RowItem 
    {
        public List<UnitItem> Units { get; set; } = new List<UnitItem>();
    }

    public class UnitItem
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }

    #endregion

    #region New Booking

    public class NewBookingRequest : ServerNewBookingModel
    {
    }

    public class NewBookingResponse
    {
        public int ID { get; set; }
    }

    #endregion
}