using ASPNetCoreInfo.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreInfo.Models
{
    public class SaveChangesViewModel
    {
        public Customer Customer { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}
