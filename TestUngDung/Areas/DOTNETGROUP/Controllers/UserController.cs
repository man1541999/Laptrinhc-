using ModelEF;
using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.Areas.DOTNETGROUP.Data;

namespace TestUngDung.Areas.DOTNETGROUP.Controllers
{
    public class UserController : BaseController
    {
        // GET: DOTNETGROUP/User
        //public ActionResult Index()
        //{
        //    var session = (LoginModel)Session[Constants.USER_SESSION];
        //    if (session == null) return RedirectToAction("Index", "Login");
        //    var user = new UserDao();
        //    var model = user.ListAll();
        //    return View(model);
        //}
        //[HttpPost]
        public ActionResult Index(string searchString,int page=1,int pagesize=5) { 
            var user = new UserDao();
            var model = user.ListwhereAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        //public ActionResult Delete(string usename)
        //{
        //    var dao = new UserDao().Delete(usename);
        //    return RedirectToAction("Index");
        //}
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new UserDao().Delete(id);
            return RedirectToAction("Index");
        }
    }
}