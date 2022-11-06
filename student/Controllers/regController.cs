using student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace student.Controllers
{
    public class regController : Controller
    {
        // GET: reg
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Savereg(regModel model)
        {
            try
            {
                return Json(new { model = (new regModel().Savereg(model)) },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}