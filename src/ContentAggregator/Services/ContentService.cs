using ContentAggregator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentAggregator.Entities;

namespace ContentAggregator.Services
{
    public class ContentService : IContentService
    {
        private readonly ITimeService _timeService;

        public ContentService(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public IEnumerable<ContentItem> Query(string text)
        {
            yield return
                new ContentItem
                {
                    OriginalUrl = "http://original.url",
                    FinalUrl = "https://final.url",
                    Title = "Mock Title",
                    Description = "Mock Description",
                    CreationTime = _timeService.Now,
                    Time = new DateTime(2017, 03, 26),
                    ContentType = "text/html",
                    Error = null,
                    Content = "Mock Content"
                };
        }
    }
}
