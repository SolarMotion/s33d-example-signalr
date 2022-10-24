using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApi.Enums;
using static WebApi.Helpers.CommonExtension;

namespace WebApi.BALs
{
    public class BaseBAL
    {
        internal readonly string _version = ApiVersion.One.GetEnumDescription();
        internal readonly int _lastAccessID = 0;
        internal DateTime _dateTimeNow = DateTime.Now;
        internal readonly string _currentTime = GetTime();
    }
}