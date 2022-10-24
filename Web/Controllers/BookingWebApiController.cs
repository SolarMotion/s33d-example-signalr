using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class BookingWebApiController : Controller
    {
        public ActionResult Index(int floor = 1)
        {
            var statusAvailable = "Available";
            var statusPending = "Pending";
            var statusSold = "Sold";

            var floor1 = new BookingWebApiViewModel()
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
                                CssID = "flex-item-1",
                                Name = "A1",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 2,
                                CssID = "flex-item-2",
                                Name = "A2",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 3,
                                CssID = "flex-item-3",
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
                                CssID = "flex-item-4",
                                Name = "B1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 5,
                                CssID = "flex-item-5",
                                Name = "B2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 6,
                                CssID = "flex-item-6",
                                Name = "B3",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 7,
                                CssID = "flex-item-7",
                                Name = "B4",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 8,
                                CssID = "flex-item-8",
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
                                CssID = "flex-item-9",
                                Name = "C1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 10,
                                CssID = "flex-item-10",
                                Name = "C2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 11,
                                CssID = "flex-item-11",
                                Name = "C3",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 12,
                                CssID = "flex-item-12",
                                Name = "C4",
                                Status = statusSold,
                            },
                        }
                    },
                }
            };

            var floor2 = new BookingWebApiViewModel()
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
                                CssID = "flex-item-13",
                                Name = "A1",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 14,
                                CssID = "flex-item-14",
                                Name = "A2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 15,
                                CssID = "flex-item-15",
                                Name = "A3",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 16,
                                CssID = "flex-item-16",
                                Name = "A4",
                                Status = statusPending,
                            },
                            new UnitItem()
                            {
                                ID = 17,
                                CssID = "flex-item-17",
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
                                CssID = "flex-item-18",
                                Name = "B1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 19,
                                CssID = "flex-item-19",
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
                                CssID = "flex-item-20",
                                Name = "C1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 21,
                                CssID = "flex-item-21",
                                Name = "C2",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 22,
                                CssID = "flex-item-22",
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