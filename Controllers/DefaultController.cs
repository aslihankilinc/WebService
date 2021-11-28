using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Services;

namespace WepService.Controllers
{
    public class DefaultController : ApiController
    {
        [WebMethod]
        public List<User> getUser()
        {
            DataModel dm = new DataModel();
            var userLst = dm.User.ToList();
            return userLst;
        }

    }
}
