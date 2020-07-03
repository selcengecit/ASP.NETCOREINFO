using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreInfo.Entities;
using ASPNetCoreInfo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetCoreInfo.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index3()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Selcen", Lastname = "Geçit", City = "Hatay" },
                new Customer { Id = 2, Name = "Selcen2", Lastname = "Geçit2", City = "Hatay2" },
                new Customer { Id = 3, Name = "Selcen3", Lastname = "Geçit3", City = "Hatay3" }


            };
            List<string> shops = new List<string>
            {
                "Ankara","İstanbul","İzmir"
            };
            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops

            };
            return View(model);
        }
        //YAZILMADIYSA DEFAULT GET
        [HttpGet]
        public IActionResult SaveChanges()
        {
            return View(new SaveChangesViewModel
            {
                Cities = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Ankara", Value = "01" },
                    new SelectListItem { Text = "İstanbul", Value = "34" },
                    new SelectListItem { Text = "İzmir", Value = "35" }
                }
            });
           }
        
        [HttpPost]
        public string SaveChanges(Customer customer)
        {
            return "Kaydedildi!";
        }
    }
}
