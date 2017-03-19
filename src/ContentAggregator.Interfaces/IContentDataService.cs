using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentAggregator.Entities;

namespace ContentAggregator.Interfaces
{
    public interface IContentDataService
    {
        void Update(IEnumerable<ContentItem> contentItems);
    }
}
