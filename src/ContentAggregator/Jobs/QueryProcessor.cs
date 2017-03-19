using ContentAggregator.Interfaces;
using System.Linq;
using ContentAggregator.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContentAggregator.Jobs
{
    public class QueryProcessor
    {
        private readonly IContentDataService _contentDataService;
        private readonly IContentService _contentService;
        private readonly IQueryDataService _queryDataService;
        private readonly ITimeService _timeService;

        public QueryProcessor(ITimeService timeService, IQueryDataService queryDataService, IContentDataService contentDataService, IContentService contentService)
        {
            _timeService = timeService;
            _queryDataService = queryDataService;
            _contentDataService = contentDataService;
            _contentService = contentService;
        }

        public void ProcessQueries()
        {
            var now = _timeService.Now;
            var queries = _queryDataService.GetUnprocessed(now);
            var contentItems = queries.AsParallel().WithDegreeOfParallelism(3)
                .SelectMany(q => _contentService.Query(q.Text));
            _contentDataService.Update(contentItems);
        }
    }
}
