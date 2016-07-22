using Shelterme.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shelterme.Controllers
{
    public class HomeController : BaseController
    {



        public ActionResult Index()
        {

            var provider = new ShelterProvider()
            {
                UserId = UserId,
                ShelterProviderName = "hi"
            };

            UnitOfWork.ShelterProviders.Add(provider);

            UnitOfWork.SaveChanges();



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}