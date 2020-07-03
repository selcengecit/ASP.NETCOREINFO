using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreInfo.Entities;
using ASPNetCoreInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreInfo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    
    }
}