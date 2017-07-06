using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApp.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Store page";
        }

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Genre = " + genre);//params
            return message;
        }

        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;//url
            return message;
        }
    }
}