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
    public class GynaePhyExaminationController : Controller
    {
        GynaePhysicalExamBL obj = new GynaePhysicalExamBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/GynaePhyExamination
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

        // GET: PN/GynaePhyExamination/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PN/GynaePhyExamination/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.Lungscondition = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text");
            ViewBag.Thyroid = new SelectList(Dropdowns.Thyroid, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.VaginalExamination = new SelectList(Dropdowns.VaginalExamination, "Value", "Text");
            ViewBag.UterusNl = new SelectList(Dropdowns.Uterus, "Value", "Text");
            ViewBag.AdnexaLeft = new SelectList(Dropdowns.AdnexaLeft, "Value", "Text");
            ViewBag.AdnexaRight = new SelectList(Dropdowns.AdnexaRight, "Value", "Text");
            return View();
        }

        // POST: PN/GynaePhyExamination/Create
        [HttpPost]
        public ActionResult Create(Gynae_PhysicalExamination model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/GynaePhyExamination/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.Lungscondition = new SelectList(Dropdowns.LungsRespiration, "Value", "Text",model.lungscondition);
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text",model.HeartRate);
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text",model.HeartRythm);
            ViewBag.Thyroid = new SelectList(Dropdowns.Thyroid, "Value", "Text",model.Thyroid);
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text",model.Abdomen);
            ViewBag.VaginalExamination = new SelectList(Dropdowns.VaginalExamination, "Value", "Text",model.VaginalExamination);
            ViewBag.UterusNl = new SelectList(Dropdowns.Uterus, "Value", "Text",model.UterusNl);
            ViewBag.AdnexaLeft = new SelectList(Dropdowns.AdnexaLeft, "Value", "Text",model.AdnexaLeft);
            ViewBag.AdnexaRight = new SelectList(Dropdowns.AdnexaRight, "Value", "Text",model.AdnexaRight);
            return View(model);
        }

        // POST: PN/GynaePhyExamination/Edit/5
        [HttpPost]
        public ActionResult Edit(Gynae_PhysicalExamination model)
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

        // POST: PN/GynaePhyExamination/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
        #region ---Tabs
        [HttpGet]
        public ActionResult GeneralTab()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            return View();
        }

        [HttpPost]
        public ActionResult GeneralTab(GynaeForm model)
        {
            GynaeBL obj = new GynaeBL();
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("PhysicalExaminationTab", "GynaePhyExamination", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            return View();
        }

        [HttpGet]
        public ActionResult PhysicalExaminationTab(int PatientId)
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", PatientId);
            ViewBag.Lungscondition = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text");
            ViewBag.Thyroid = new SelectList(Dropdowns.Thyroid, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.VaginalExamination = new SelectList(Dropdowns.VaginalExamination, "Value", "Text");
            ViewBag.UterusNl = new SelectList(Dropdowns.Uterus, "Value", "Text");
            ViewBag.AdnexaLeft = new SelectList(Dropdowns.AdnexaLeft, "Value", "Text");
            ViewBag.AdnexaRight = new SelectList(Dropdowns.AdnexaRight, "Value", "Text");
            return View();
        }
        [HttpPost]
        public ActionResult PhysicalExaminationTab(Gynae_PhysicalExamination model)
        {
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("LabtestTab", "GynaePhyExamination", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.Lungscondition = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text");
            ViewBag.Thyroid = new SelectList(Dropdowns.Thyroid, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.VaginalExamination = new SelectList(Dropdowns.VaginalExamination, "Value", "Text");
            ViewBag.UterusNl = new SelectList(Dropdowns.Uterus, "Value", "Text");
            ViewBag.AdnexaLeft = new SelectList(Dropdowns.AdnexaLeft, "Value", "Text");
            ViewBag.AdnexaRight = new SelectList(Dropdowns.AdnexaRight, "Value", "Text");
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
            LabTestBL obj = new LabTestBL();
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("AssessmentTab", "GynaePhyExamination", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            return View(model);
        }

        [HttpGet]
        public ActionResult AssessmentTab(int PatientId)
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", PatientId);

            PreNatal_Assessment model = new PreNatal_Assessment();
            return View(model);
        }
        [HttpPost]
        public ActionResult AssessmentTab(PreNatal_Assessment model)
        {
            AssessmentBL obj = new AssessmentBL();
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("MedicationTab", "GynaePhyExamination", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");

            return View(model);
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
            MedicationBL obj = new MedicationBL();
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("PlanTab", "GynaePhyExamination", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.VisitNo = new SelectList(Dropdowns.VisitNumber, "Value", "Text");
            ViewBag.CheckupOf = new SelectList(Dropdowns.CheckupOf, "Value", "Text");
            return View(model);
        }

        public ActionResult PlanTab(int PatientId)
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", PatientId);

            PreNatal_Plan model = new PreNatal_Plan();
            return View(model);
        }
        [HttpPost]
        public ActionResult PlanTab(PreNatal_Plan model)
        {
            PlanBL obj = new PlanBL();
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("GeneralTab", "GynaePhyExamination", new { area = "PN" });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");

            return View(model);
        }
        #endregion

    }
}
