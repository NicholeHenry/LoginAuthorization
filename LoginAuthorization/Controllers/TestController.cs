using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAuthorization.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginAuthorization.Controllers
{
    public class TestController : Controller
    {
        private ApplicationDbContext context;



        public TestController(ApplicationDbContext context)

        {

            this.context = context;

        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            ViewData["role"] = "Admin";
            return View();
        }
    }
}