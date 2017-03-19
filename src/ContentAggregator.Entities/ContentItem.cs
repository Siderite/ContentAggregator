using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentAggregator.Entities
{
    public class ContentItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string OriginalUrl { get; set; }
        public string FinalUrl { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime Time { get; set; }
        public string Error { get; set; }
    }
}
