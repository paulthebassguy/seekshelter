using Microsoft.AspNet.Identity;
using Shelterme.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shelterme.Controllers
{
    public class BaseController : Controller
    {

        protected SheltermeContext UnitOfWork { get; set; }
        protected Guid UserId { get; set; }

        public BaseController()
        {

            UnitOfWork = new SheltermeContext();
        }


        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            var userId = User != null && User.Identity != null ? User.Identity.GetUserId() : string.Empty;
            var userGuid = !string.IsNullOrEmpty(userId) ? new Guid(userId) : null as Guid?;

            if (userGuid != null)
                UserId = userGuid.Value;
            

            base.OnActionExecuting(filterContext);
        }

    }
}