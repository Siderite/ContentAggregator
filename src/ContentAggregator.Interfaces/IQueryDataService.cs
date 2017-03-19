using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentAggregator.Entities;

namespace ContentAggregator.Interfaces
{
    public interface IQueryDataService
    {
        IEnumerable<Query> GetUnprocessed(DateTime now);
    }
}
