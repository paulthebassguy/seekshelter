using Shelterme.Data.Models;
using Shelterme.Models;
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

            //var provider = new ShelterProvider()
            //{
            //    UserId = UserId,
            //    ShelterProviderName = "hi"
            //};

            //UnitOfWork.ShelterProviders.Add(provider);

            //UnitOfWork.SaveChanges();



            return View();
        }


        [AllowAnonymous]
        public ActionResult RegisterAvailability()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult RegisterAvailability(RegisterDetailsViewModel model)
        {
            var shelterProvider = UnitOfWork.ShelterProviders.FirstOrDefault(s => s.UserId == UserId);

            shelterProvider.MaxBedsAvailable = model.MaxBedsAvailable;
            shelterProvider.AllowChildren = model.AllowChildren;
            shelterProvider.AllowMen = model.AllowMen;
            shelterProvider.AllowWomen = model.AllowWomen;

            UnitOfWork.SaveChanges();

            return View("RegisterContact");
        }

        [AllowAnonymous]
        public ActionResult RegisterContact()
        {


            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public ActionResult RegisterContact(RegisterDetailsViewModel model)
        {

            var shelterProvider = UnitOfWork.ShelterProviders.FirstOrDefault(s => s.UserId == UserId);

            shelterProvider.Address = model.Address;
            shelterProvider.City = model.City;
            shelterProvider.ContactDetails = model.ContactDetails;
            shelterProvider.ShelterProviderName = model.ShelterProviderName;
            shelterProvider.Suburb = model.Suburb;

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