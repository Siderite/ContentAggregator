using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentAggregator.Entities
{
    public class Query
    {
        public string Text { get; set; }
        public TimeSpan Interval { get; set; }
        public int Count { get; set; }
        public DateTime LastProcessed { get; set; }
    }
}
