using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreInfo.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreInfo.Controllers
{
    public class SessionDemoController : Controller
    {
        
        public string Index1()
        {
            Customer customer = new Customer {Id=1,Name="Engin"};
           
            HttpContext.Session.SetString(key: "isim", "Engin");
            return "Session Oluştu";
        }

        public string Index2()
        {
            
            return HttpContext.Session.GetString(key: "isim");
        }
    }
}