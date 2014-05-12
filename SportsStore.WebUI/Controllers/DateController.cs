using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class DateController : Controller
    {        
        public PartialViewResult CurrentDate()
        {
            var d = DateTime.Now;
            return PartialView(d);
        }
    }
}