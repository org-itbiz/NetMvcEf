using Net.BizDac.Store;
using Net.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<MemberT> members = new MemberBiz().getAllMembers();
            return View(members);
        }

    }
}
