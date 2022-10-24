using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class BookingUIViewModel
    {
        public int Floor { get; set; }
        public List<RowItem> Rows { get; set; } = new List<RowItem>();
    }

    public class RowItem
    {
        public List<UnitItem> Units { get; set; } = new List<UnitItem>();
    }

    public class UnitItem
    {
        public int ID { get; set; }

        public string CssID { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }

}