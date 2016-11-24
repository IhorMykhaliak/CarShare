using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarShare.BL;

namespace CarShare.WebUI.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public string Index()
        {
            var userpr = new UsersProvider();
            userpr.AddDefaultUser();
            return userpr.Gesdfsd();
        }
        
    }
}