using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentAggregator.Interfaces
{
    public interface ITimeService
    {
        DateTime Now
        {
            get;
        }
    }
}
