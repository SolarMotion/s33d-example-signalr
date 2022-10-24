using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class BookingUIController : Controller
    {
        public ActionResult Index(int floor = 1)
        {
            var statusAvailable = "Available";
            var statusPending = "Pending";
            var statusSold = "Sold";

            var floor1 = new BookingUIViewModel()
            {
                Floor = floor,
                Rows = new List<RowItem>()
                {
                    new RowItem()
                    {
                        Units = new List<UnitItem>()
                        {
                            new UnitItem()
                            {
                                ID = 1,
                                CssID = "flex-item-A1",
                                Name = "A1",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 2,
                                CssID = "flex-item-A2",
                                Name = "A2",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 3,
                                CssID = "flex-item-A3",
                                Name = "A3",
                                Status = statusAvailable,
                            },
                        }
                    },
                    new RowItem()
                    {
                        Units = new List<UnitItem>()
                        {
                            new UnitItem()
                            {
                                ID = 4,
                                CssID = "flex-item-B1",
                                Name = "B1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 5,
                                CssID = "flex-item-B2",
                                Name = "B2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 6,
                                CssID = "flex-item-B3",
                                Name = "B3",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 7,
                                CssID = "flex-item-B4",
                                Name = "B4",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 8,
                                CssID = "flex-item-B5",
                                Name = "B5",
                                Status = statusPending,
                            },
                        }
                    },
                    new RowItem()
                    {
                        Units = new List<UnitItem>()
                        {
                            new UnitItem()
                            {
                                ID = 9,
                                CssID = "flex-item-C1",
                                Name = "C1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 10,
                                CssID = "flex-item-C2",
                                Name = "C2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 11,
                                CssID = "flex-item-C3",
                                Name = "C3",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 12,
                                CssID = "flex-item-C4",
                                Name = "C4",
                                Status = statusSold,
                            },
                        }
                    },
                }
            };

            var floor2 = new BookingUIViewModel()
            {
                Floor = floor,
                Rows = new List<RowItem>()
                {
                    new RowItem()
                    {
                        Units = new List<UnitItem>()
                        {
                            new UnitItem()
                            {
                                ID = 13,
                                CssID = "flex-item-A1",
                                Name = "A1",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 14,
                                CssID = "flex-item-A2",
                                Name = "A2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 15,
                                CssID = "flex-item-A3",
                                Name = "A3",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 16,
                                CssID = "flex-item-A4",
                                Name = "A4",
                                Status = statusPending,
                            },
                            new UnitItem()
                            {
                                ID = 17,
                                CssID = "flex-item-A5",
                                Name = "A5",
                                Status = statusAvailable,
                            },
                        }
                    },
                    new RowItem()
                    {
                        Units = new List<UnitItem>()
                        {
                            new UnitItem()
                            {
                                ID = 18,
                                CssID = "flex-item-B1",
                                Name = "B1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 19,
                                CssID = "flex-item-B2",
                                Name = "B2",
                                Status = statusSold,
                            },
                        }
                    },
                    new RowItem()
                    {
                        Units = new List<UnitItem>()
                        {
                            new UnitItem()
                            {
                                ID = 20,
                                CssID = "flex-item-C1",
                                Name = "C1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 21,
                                CssID = "flex-item-C2",
                                Name = "C2",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 22,
                                CssID = "flex-item-C3",
                                Name = "C3",
                                Status = statusPending,
                            },
                        }
                    },
                }
            };

            if (floor == 1)
            {
                return View(floor1);
            }
            else
            {
                return View(floor2);
            }
        }
    }
}