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
    public class CouncelController : Controller
    {
        CouncelBL obj = new CouncelBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/Councel
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }
        // GET: PN/Councel/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            return View();
        }

        // POST: PN/Councel/Create
        [HttpPost]
        public ActionResult Create(PreNatal_Counsel model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/Councel/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text", model.VisitNo);
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text",model.CheckupOf);
            return View(model);
        }

        // POST: PN/Councel/Edit/5
        [HttpPost]
        public ActionResult Edit(PreNatal_Counsel model)
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

        // GET: PN/Councel/Delete/5
        [HttpPost]
        public JsonResult DeleteCouncel(int councelId)
        {
            obj.Delete(councelId, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult CouncelTab(int PatientId)
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            PreNatal_Counsel model = new PreNatal_Counsel();
            return View(model);
        }
        [HttpPost]
        public ActionResult CouncelTab(PreNatal_Counsel model)
        {
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("PhysicalExamTab", "PreNatalPhyExamination", new { area = "PN" });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            return View(model);
        }

        public ActionResult CounselPartial(int mrno)
        {
            PreNatal_Counsel model = new PreNatal_Counsel();
            model = obj.PopulateByMrNumber(mrno, out outmodel);
            if (model == null)
            {
                model = new PreNatal_Counsel();
                model.RecordExist = false;
            }
            else
                model.RecordExist = true;
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text", model.VisitNo);
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text", model.CheckupOf);
         
            return PartialView("~/Views/Shared/Prenatal/_Counsel.cshtml", model);
        }
    }
}
