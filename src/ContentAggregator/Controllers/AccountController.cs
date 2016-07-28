using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Authentication;

namespace ContentAggregator.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(string ReturnUrl)
        {
            return new ChallengeResult("Google",new AuthenticationProperties
            {
                RedirectUri = ReturnUrl ?? "/"
            });
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.Authentication.SignOutAsync("Cookies");

            return RedirectToAction("index", "home");
        }
    }
}