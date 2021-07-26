using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filter.CustomFilters;
using Microsoft.AspNetCore.Mvc;

namespace Filter.Controllers
{
    [TimeElapsed]
    public class HomeController : Controller
    {
        //[HttpsOnly]
        //public string Index()
        //{
        //    return "This is the Index action on the Home controller";
        //}

        //[ChangeView]
        //public ViewResult Message() => View();

        [HttpsOnly]
        
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }

        [HybridActRes]
        public IActionResult List() => View();

        [CatchError]
        public IActionResult Exception(int? id)
        {

            if (id == null)
                throw new Exception("Error Id cannot be null");
            else
                return View((object)$"The value is {id}");

        }

    }
}