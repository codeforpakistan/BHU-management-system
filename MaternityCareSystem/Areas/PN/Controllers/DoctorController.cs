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
    [Authorize(Roles ="Admin")]
    public class DoctorController : Controller
    {
        // GET: PN/Doctor
        DoctorBL obj = new DoctorBL();
        OutParamModel outmodel = new OutParamModel();
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

   
        // GET: PN/Doctor/Create
        public ActionResult Create()
        {
            ViewBag.SpecializationId = new SelectList(Dropdowns.SpecializaionDDL, "Value", "Text");
            return View();
        }

        // POST: PN/Doctor/Create
        [HttpPost]
        public ActionResult Create(DoctorInfo model)
        {
            try
            {
                // TODO: Add insert logic here
                var toReturn = obj.Save(model, out outmodel);
                return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
            }
            catch
            {
                return View();
            }
        }

        // GET: PN/Doctor/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.SpecializationId = new SelectList(Dropdowns.SpecializaionDDL, "Value", "Text",model.SpecializationId);
            return View(model);
        }

        // POST: PN/Doctor/Edit/5
        [HttpPost]
        public ActionResult Edit(DoctorInfo model)
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
            catch
            {
                return View();
            }
        }


        // POST: PN/Doctor/Delete/5
        [HttpPost]
        public JsonResult Delete(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
    }
}
