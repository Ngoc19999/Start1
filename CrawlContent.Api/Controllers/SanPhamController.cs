﻿using Microsoft.AspNetCore.Mvc;

namespace CrawlContent.Api.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
