using ContentAggregator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentAggregator.Entities;
using System.Text;

namespace ContentAggregator.Services
{
    public class ContentDataService : IContentDataService
    {
        private readonly static StringBuilder _sb;

        static ContentDataService()
        {
            _sb = new StringBuilder();
        }

        public void Update(IEnumerable<ContentItem> contentItems)
        {
            foreach (var contentItem in contentItems)
            {
                _sb.AppendLine($"{contentItem.FinalUrl}:{contentItem.Title}");
            }
        }

        public static string Output
        {
            get { return _sb.ToString(); }
        }
    }
}
