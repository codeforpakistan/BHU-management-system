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
    public class PreNatalPhyExaminationController : Controller
    {
        // GET: PN/PreNatalPhyExamination
        PreNatalPhysicalExaminationBL obj = new PreNatalPhysicalExaminationBL();
        OutParamModel outmodel = new OutParamModel();
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

        public ActionResult PrenatalPhyExamPartial(int mrno)
        {
            PreNatal_PhysicalExamination model = new PreNatal_PhysicalExamination();
            model = obj.PopulateByMrNumber(mrno,out outmodel);
            if (model == null)
            {
                model = new PreNatal_PhysicalExamination();
                model.RecordExist = false;
            }
            else
                model.RecordExist = true;
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text",model.PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text",model.VisitNo);
            ViewBag.GeneralAppearance = new SelectList(Dropdowns.Appearance, "Value", "Text",model.GeneralAppearance);
            ViewBag.Lungs = new SelectList(Dropdowns.Lungs, "Value", "Text",model.Lungs);
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text",model.Abdomen);
            ViewBag.FetalPosition = new SelectList(Dropdowns.FetalPosition, "Value", "Text",model.FetalPosition);
            ViewBag.Edema = new SelectList(Dropdowns.Edema, "Value", "Text",model.Edema);

           
            return PartialView("~/Views/Shared/Prenatal/_PrenatalPhysicalExamination.cshtml", model);
        }
        public ActionResult PrenataPhysicalExamination()
        {
            Int64 mrno = 0;
            
            return View(mrno);
        }
        [HttpPost]
        public ActionResult PrenataPhysicalExamination(Int64 MrNumber)
        {
            Int64 mrno = MrNumber;
            return View(mrno);
        }
        // GET: PN/PreNatalPhyExamination/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.GeneralAppearance = new SelectList(Dropdowns.Appearance, "Value", "Text");
            ViewBag.Lungs = new SelectList(Dropdowns.Lungs, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.FetalPosition = new SelectList(Dropdowns.FetalPosition, "Value", "Text");
            ViewBag.Edema = new SelectList(Dropdowns.Edema, "Value", "Text");
            return View();
        }

        // POST: PN/PreNatalPhyExamination/Create
        [HttpPost]
        public ActionResult Create(PreNatal_PhysicalExamination model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/PreNatalPhyExamination/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text",model.PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text",model.VisitNo);
            ViewBag.GeneralAppearance = new SelectList(Dropdowns.Appearance, "Value", "Text",model.GeneralAppearance);
            ViewBag.Lungs = new SelectList(Dropdowns.Lungs, "Value", "Text",model.Lungs);
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text",model.Abdomen);
            ViewBag.FetalPosition = new SelectList(Dropdowns.FetalPosition, "Value", "Text", model.FetalPosition);
            ViewBag.Edema = new SelectList(Dropdowns.Edema, "Value", "Text", model.Edema);
            return View(model);
        }

        // POST: PN/PreNatalPhyExamination/Edit/5
        [HttpPost]
        public ActionResult Edit(PreNatal_PhysicalExamination model)
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

        // POST: PN/PreNatalPhyExamination/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult PhysicalExamTab()
        {

            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.GeneralAppearance = new SelectList(Dropdowns.Appearance, "Value", "Text");
            ViewBag.Lungs = new SelectList(Dropdowns.Lungs, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.FetalPosition = new SelectList(Dropdowns.FetalPosition, "Value", "Text");
            ViewBag.Edema = new SelectList(Dropdowns.Edema, "Value", "Text");
            return View();
        }
        [HttpPost]
        public ActionResult PhysicalExamTab(PreNatal_PhysicalExamination model)
        {
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("LabtestTab", "LabTest", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.GeneralAppearance = new SelectList(Dropdowns.Appearance, "Value", "Text");
            ViewBag.Lungs = new SelectList(Dropdowns.Lungs, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            return View();
        }
        [HttpGet]
        public ActionResult PopulateForm(int MrNumber)
        {
            var model = obj.PopulateByMrNumber(MrNumber, out outmodel);
            if (model != null)
            {
                ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
                ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text",model.VisitNo);
                ViewBag.GeneralAppearance = new SelectList(Dropdowns.Appearance, "Value", "Text",model.GeneralAppearance);
                ViewBag.Lungs = new SelectList(Dropdowns.Lungs, "Value", "Text",model.Lungs);
                ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text",model.Abdomen);
                 ViewBag.FetalPosition = new SelectList(Dropdowns.FetalPosition, "Value", "Text", model.FetalPosition);
            ViewBag.Edema = new SelectList(Dropdowns.Edema, "Value", "Text", model.Edema);
                return View("~/Areas/PN/Views/PreNatalPhyExamination/PhysicalExamTab.cshtml", model);
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.GeneralAppearance = new SelectList(Dropdowns.Appearance, "Value", "Text");
            ViewBag.Lungs = new SelectList(Dropdowns.Lungs, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.FetalPosition = new SelectList(Dropdowns.FetalPosition, "Value", "Text");
            ViewBag.Edema = new SelectList(Dropdowns.Edema, "Value", "Text");
            return View("~/Areas/PN/Views/PreNatalPhyExamination/PhysicalExamTab.cshtml");

        }
    }
}
