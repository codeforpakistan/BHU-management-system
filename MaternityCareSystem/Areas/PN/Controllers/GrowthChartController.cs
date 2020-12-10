using MaternityCareSystem.Areas.PN.BL;
using MaternityCareSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaternityCareSystem.Areas.PN.Controllers
{
    [AllowAnonymous]
    public class GrowthChartController : Controller
    {
        ChartsBL obj = new ChartsBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/GrowthChart
        public ActionResult Charts()
        {
            return View();
        }
        public ActionResult VisitSummary()
        {
            int MrNumber = 0;
            return View(MrNumber);
        }
        [HttpPost]
        public ActionResult VisitSummary(int MrNumber)
        {
            //int MrNumber = 0;
            return View(MrNumber);
        }
        public ActionResult GetVisitSummary(int MrNumber)
        {
            SqlParameter[] parameter =
            {
                  new SqlParameter("@MrNumber", MrNumber)
            };
            DataSet ds = obj.GetDataSet("sp_PrenatlVisitSummary", parameter);
            return PartialView("~/Views/Shared/Prenatal/_PrenataVisitSummary.cshtml", ds.Tables[0]);
        }
        [HttpGet]
        public JsonResult GetMaleWeight()
        {
            var res = obj.GetAll("MaleWeight", out outmodel);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetMaleHeight()
        {
            var res = obj.GetAll("MaleHeight", out outmodel);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetFemaleWeight()
        {
            var res = obj.GetAll("FemaleWeight", out outmodel);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetFemaleHeight()
        {
            var res = obj.GetAll("FemaleHeight", out outmodel);
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetMaleLength()
        {
            var res = obj.GetAll("MaleLength", out outmodel);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetFemaleLength()
        {
            var res = obj.GetAll("FemaleLength", out outmodel);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}