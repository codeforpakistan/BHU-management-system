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
    public class LabTestController : Controller
    {
        LabTestBL obj = new LabTestBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/LabTest
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }


        // GET: PN/LabTest/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");

            ViewBag.BloodGroup = new SelectList(Dropdowns.BloodGroup, "Value", "Text");
            ViewBag.Protein = new SelectList(Dropdowns.Protien, "Value", "Text");
            ViewBag.Glucose = new SelectList(Dropdowns.Glucose, "Value", "Text");
            ViewBag.WBC = new SelectList(Dropdowns.WBC, "Value", "Text");
            ViewBag.Keytone = new SelectList(Dropdowns.Keytone, "Value", "Text");
            ViewBag.Blood = new SelectList(Dropdowns.Blood, "Value", "Text");
            return View();
        }
        [HttpGet]
        public ActionResult LabtestTab(int PatientId)
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");

            ViewBag.BloodGroup = new SelectList(Dropdowns.BloodGroup, "Value", "Text");
            ViewBag.Protein = new SelectList(Dropdowns.Protien, "Value", "Text");
            ViewBag.Glucose = new SelectList(Dropdowns.Glucose, "Value", "Text");
            ViewBag.WBC = new SelectList(Dropdowns.WBC, "Value", "Text");
            ViewBag.Keytone = new SelectList(Dropdowns.Keytone, "Value", "Text");
            ViewBag.Blood = new SelectList(Dropdowns.Blood, "Value", "Text");
            PreNatal_LabTest model = new PreNatal_LabTest();
            return View(model);
        }
        [HttpPost]
        public ActionResult LabtestTab(PreNatal_LabTest model)
        {
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("MedicationTab", "Medication", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            return View(model);
        }
        // POST: PN/LabTest/Create
        [HttpPost]
        public ActionResult Create(PreNatal_LabTest model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/LabTest/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text",model.VisitNo);
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text",model.CheckupOf);

            ViewBag.BloodGroup = new SelectList(Dropdowns.BloodGroup, "Value", "Text",model.BloodGroup);
            ViewBag.Protein = new SelectList(Dropdowns.Protien, "Value", "Text",model.Protein);
            ViewBag.Glucose = new SelectList(Dropdowns.Glucose, "Value", "Text",model.Glucose);
            ViewBag.WBC = new SelectList(Dropdowns.WBC, "Value", "Text",model.WBC);
            ViewBag.Keytone = new SelectList(Dropdowns.Keytone, "Value", "Text",model.Keytone);
            ViewBag.Blood = new SelectList(Dropdowns.Blood, "Value", "Text",model.Blood);
            return View(model);
        }

        // POST: PN/LabTest/Edit/5
        [HttpPost]
        public ActionResult Edit(PreNatal_LabTest model)
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

        // GET: PN/LabTest/Delete/5
        [HttpPost]
        public JsonResult DeleteLabTest(int testId)
        {
            obj.Delete(testId, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult LabtestPartial(int mrno)
        {
            PreNatal_LabTest model = new PreNatal_LabTest();
            model = obj.PopulateByMrNumber(mrno, out outmodel);
            if (model == null)
            {
                model = new PreNatal_LabTest();
                model.RecordExist = false;
            }
            else
                model.RecordExist = true;
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text", model.VisitNo);
          

            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text",model.CheckupOf);
            ViewBag.BloodGroup = new SelectList(Dropdowns.BloodGroup, "Value", "Text",model.BloodGroup);
            ViewBag.Protein = new SelectList(Dropdowns.Protien, "Value", "Text",model.Protein);
            ViewBag.Glucose = new SelectList(Dropdowns.Glucose, "Value", "Text",model.Glucose);
            ViewBag.WBC = new SelectList(Dropdowns.WBC, "Value", "Text",model.WBC);
            ViewBag.Keytone = new SelectList(Dropdowns.Keytone, "Value", "Text",model.Keytone);
            ViewBag.Blood = new SelectList(Dropdowns.Blood, "Value", "Text",model.Keytone);
            return PartialView("~/Views/Shared/Prenatal/_LabTest.cshtml", model);
        }
    }
}
