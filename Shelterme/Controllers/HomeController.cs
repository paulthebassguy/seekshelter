using Shelterme.Data.Models;
using Shelterme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shelterme.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {



        public ActionResult Index()
        {
            

            return View();
        }


        [AllowAnonymous]
        public ActionResult RegisterAvailability()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterAvailability(RegisterDetailsViewModel model)
        {
            var shelterProvider = UnitOfWork.ShelterProviders.FirstOrDefault(s => s.UserId == UserId);

            if (shelterProvider == null) return RedirectToAction("Register", "Account");

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


        
        [HttpPost]
        public ActionResult RegisterContact(RegisterDetailsViewModel model)
        {

            var shelterProvider = UnitOfWork.ShelterProviders.FirstOrDefault(s => s.UserId == UserId);

            if (shelterProvider == null) return RedirectToAction("Register", "Account");

            shelterProvider.Address = model.Address;
            shelterProvider.City = model.City;
            shelterProvider.ContactDetails = model.ContactDetails;
            shelterProvider.ShelterProviderName = model.ShelterProviderName;
            shelterProvider.Suburb = model.Suburb;

            UnitOfWork.SaveChanges();

            return View("Confirmation");
        }

        
        public ActionResult Confirmation()
        {
            var shelterProvider = UnitOfWork.ShelterProviders.FirstOrDefault(s => s.UserId == UserId);

            if (shelterProvider == null) return RedirectToAction("Register", "Account");

            var model = new RegisterDetailsViewModel()
            {
                Address = shelterProvider.Address,
                AllowChildren = shelterProvider.AllowChildren,
                AllowMen = shelterProvider.AllowMen,
                AllowWomen = shelterProvider.AllowWomen,
                City = shelterProvider.City,
                ContactDetails = shelterProvider.ContactDetails,
                MaxBedsAvailable = shelterProvider.MaxBedsAvailable,
                ShelterProviderName = shelterProvider.ShelterProviderName,
                Suburb = shelterProvider.Suburb
            };

            return View(model);
        }

        public ActionResult AdminPage()
        {

            var shelterProvider = UnitOfWork.ShelterProviders.FirstOrDefault(s => s.UserId == UserId);

            if (shelterProvider == null) return RedirectToAction("Register", "Account");

            var model = new AdminPageViewModel()
            {
                
                AllowChildren = shelterProvider.AllowChildren,
                AllowMen = shelterProvider.AllowMen,
                AllowWomen = shelterProvider.AllowWomen,
                CurrentBedsAvailable = shelterProvider.CurrentBedsAvailable 
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult AdminPage(AdminPageViewModel model)
        {
            var shelterProvider = UnitOfWork.ShelterProviders.FirstOrDefault(s => s.UserId == UserId);

            if (shelterProvider == null) return RedirectToAction("Register", "Account");

            shelterProvider.CurrentBedsAvailable = model.CurrentBedsAvailable;
            shelterProvider.AllowChildren = model.AllowChildren;
            shelterProvider.AllowMen = model.AllowMen;
            shelterProvider.AllowWomen = model.AllowWomen;

            return View(model);
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