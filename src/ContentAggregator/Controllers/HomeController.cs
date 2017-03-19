using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ContentAggregator.Services;
using ContentAggregator.Jobs;
using Microsoft.Extensions.DependencyInjection;

namespace ContentAggregator.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly QueryProcessor _queryProcessor;

        public HomeController(QueryProcessor queryProcessor)
        {
            _queryProcessor = queryProcessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/test")]
        public string Test()
        {
            _queryProcessor.ProcessQueries();
            return ContentDataService.Output;
        }
    }
}
