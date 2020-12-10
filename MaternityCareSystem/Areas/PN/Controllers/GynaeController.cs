using MaternityCareSystem.Areas.PN.BL;
using MaternityCareSystem.Areas.PN.DataModels;
using MaternityCareSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaternityCareSystem.Areas.PN.Controllers
{
    [Authorize(Roles = "Admin")]
    public class GynaeController : Controller
    {
        GynaeBL obj = new GynaeBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/Gynae
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

        // GET: PN/Gynae/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            return View();
        }

        // POST: PN/Gynae/Create
        [HttpPost]
        public ActionResult Create(GynaeForm model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/Gynae/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            return View(model);
        }

        // POST: PN/Gynae/Edit/5
        [HttpPost]
        public ActionResult Edit(GynaeForm model)
        {
            try
            {
                obj.Update(model, out outmodel);
                if (!outmodel.Error)
                {
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
                return View();
            }
        }

        [HttpPost]
        public JsonResult DeleteGynaeRecord(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
    }
}
