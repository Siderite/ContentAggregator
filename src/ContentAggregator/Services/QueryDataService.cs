using ContentAggregator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentAggregator.Entities;

namespace ContentAggregator.Services
{
    public class QueryDataService : IQueryDataService
    {
        public IEnumerable<Query> GetUnprocessed(DateTime now)
        {
            yield return new Query
                {
                    Text="Some query"
                };
        }
    }
}
