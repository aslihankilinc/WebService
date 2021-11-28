using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace WepService.Controllers
{
    public class DefaultController : Controller
    {
        [WebMethod]
        public JsonResult getUser()
        {
            DataModel dm = new DataModel();
            var userLst = dm.User.ToList();
            return Json(userLst);
        }

    }
}