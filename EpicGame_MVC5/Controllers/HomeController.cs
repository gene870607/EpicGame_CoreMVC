using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpicGame_MVC5.Repositories.BusinessLogicLayer;

namespace EpicGame_MVC5.Controllers
{
    public class HomeController : Controller
    {
        private HomeBLO _rbp;
        public HomeController()
        {
            _rbp = new HomeBLO();
        }
        public ActionResult Index()
        {
            var result = _rbp.GetHomeViewModel();
            return View(result);
        }
    }
}