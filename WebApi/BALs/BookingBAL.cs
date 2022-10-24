using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApi.Models;
using static WebApi.Helpers.CommonExtension;
using static WebApi.Helpers.WebApiLogging;
using static WebApi.Helpers.Log;
using static WebApi.Helpers.CustomApiResponse;
using Microsoft.AspNet.SignalR;

using WebApi.Hubs;

namespace WebApi.BALs
{
    public class BookingBAL : BaseBAL
    {
        public ApiResponseBody Status(StatusRequest request)
        {
            try
            {
                var response = new StatusResponse() { Status = $"System is running. ==> {request.Floor}" };

                return ConstructOKResponse(response, _version);
            }
            catch (Exception ex)
            {
                PublicError(ex);
                return ConstructInternalServerErrorResponse(new StatusResponse(), _version);
            }
        }

        public ApiResponseBody Booking(BookingRequest request)
        {
            var statusAvailable = "Available";
            var statusPending = "Pending";
            var statusSold = "Sold";
            var statusList = new List<string>() { statusAvailable, statusPending, statusSold };

            var floor1 = new BookingResponse()
            {
                Rows = new List<RowItem>()
                {
                    new RowItem()
                    {
                        Units = new List<UnitItem>()
                        {
                            new UnitItem()
                            {
                                ID = 1,
                                Name = "A1",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 2,
                                Name = "A2",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 3,
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
                                Name = "B1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 5,
                                Name = "B2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 6,
                                Name = "B3",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 7,
                                Name = "B4",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 8,
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
                                Name = "C1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 10,
                                Name = "C2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 11,
                                Name = "C3",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 12,
                                Name = "C4",
                                Status = statusSold,
                            },
                        }
                    },
                }
            };

            var floor2 = new BookingResponse()
            {
                Rows = new List<RowItem>()
                {
                    new RowItem()
                    {
                        Units = new List<UnitItem>()
                        {
                            new UnitItem()
                            {
                                ID = 13,
                                Name = "A1",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 14,
                                Name = "A2",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 15,
                                Name = "A3",
                                Status = statusSold,
                            },
                            new UnitItem()
                            {
                                ID = 16,
                                Name = "A4",
                                Status = statusPending,
                            },
                            new UnitItem()
                            {
                                ID = 17,
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
                                Name = "B1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 19,
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
                                Name = "C1",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 21,
                                Name = "C2",
                                Status = statusAvailable,
                            },
                            new UnitItem()
                            {
                                ID = 22,
                                Name = "C3",
                                Status = statusPending,
                            },
                        }
                    },
                }
            };

            try
            {
                var response = new BookingResponse();
                var rand = new Random();

                if (request.Floor == 1)
                {
                    foreach (var row in floor1.Rows)
                    {
                        foreach (var unit in row.Units)
                        {
                            unit.Status = statusList[rand.Next(3)];
                        }
                    }

                    response = floor1;
                }
                else
                {
                    foreach (var row in floor2.Rows)
                    {
                        foreach (var unit in row.Units)
                        {
                            unit.Status = statusList[rand.Next(3)];
                        }
                    }

                    response = floor2;
                }

                return ConstructOKResponse(response, _version);
            }
            catch (Exception ex)
            {
                PublicError(ex);
                return ConstructInternalServerErrorResponse(new BookingResponse(), _version);
            }
        }

        public ApiResponseBody NewBooking(NewBookingRequest request)
        {
            try
            {
                var hubContext = GlobalHost.ConnectionManager.GetHubContext<BookingHub>();
                hubContext.Clients.All.clientNewBooking(request);

                var response = new NewBookingResponse()
                { 
                    ID = request.ID,                    
                };

                return ConstructOKResponse(response, _version);
            }
            catch (Exception ex)
            {
                PublicError(ex);
                return ConstructInternalServerErrorResponse(new NewBookingResponse(), _version);
            }
        }
    }
}