using ContentAggregator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentAggregator.Services
{
    public class TimeService : ITimeService
    {
        public DateTime Now
        {
            get
            {
                return DateTime.UtcNow;
            }
        }
    }
}
