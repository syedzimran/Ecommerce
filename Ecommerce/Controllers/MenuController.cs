using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Ecommerce.Models;
namespace Ecommerce.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/
       Database_Acess_Layer.DB db;
        DataTable dt;
        public ActionResult Menu()
        {
           db = new Database_Acess_Layer.DB();
           dt = new DataTable();
            dt = db.GetParentCategory();
            ViewBag.ParentCategory = dt;
            return View();
        }

    }
}
