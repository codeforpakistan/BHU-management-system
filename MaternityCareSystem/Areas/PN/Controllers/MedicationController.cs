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
    public class MedicationController : Controller
    {
        MedicationBL obj = new MedicationBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/Medication
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

        // GET: PN/Medication/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            return View();
        }

        // POST: PN/Medication/Create
        [HttpPost]
        public ActionResult Create(PreNatal_Medication model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/Medication/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text", model.VisitNo);
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text",model.CheckupOf);
            return View(model);
        }

        // POST: PN/Medication/Edit/5
        [HttpPost]
        public ActionResult Edit(PreNatal_Medication model)
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
        public JsonResult DeleteMedication(int medicationId)
        {
            obj.Delete(medicationId, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult MedicationTab(int PatientId)
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            PreNatal_Medication model = new PreNatal_Medication();
            return View(model);
        }
        [HttpPost]
        public ActionResult MedicationTab(PreNatal_Medication model)
        {
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("CouncelTab", "Councel", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            return View(model);
        }
        public ActionResult MedicationPartial(int mrno)
        {
            PreNatal_Medication model = new PreNatal_Medication();
            model = obj.PopulateByMrNumber(mrno, out outmodel);
            if (model == null)
            {
                model = new PreNatal_Medication();
                model.RecordExist = false;
            }
            else
                model.RecordExist = true;
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text", model.VisitNo);
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text", model.CheckupOf);
      
            return PartialView("~/Views/Shared/Prenatal/_Medication.cshtml", model);
        }
    }
}
