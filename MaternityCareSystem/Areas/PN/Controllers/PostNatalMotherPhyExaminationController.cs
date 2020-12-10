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
    public class PostNatalMotherPhyExaminationController : Controller
    {
        PostNatalMotherBL obj = new PostNatalMotherBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/PostNatalMotherPhyExamination
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

        // GET: PN/PostNatalMotherPhyExamination/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.DeliveryCondition = new SelectList(Dropdowns.DeliveryCondition, "Value", "Text");
            ViewBag.DeliveryTerm = new SelectList(Dropdowns.DeliveryTerm, "Value", "Text");
            ViewBag.DischargeType = new SelectList(Dropdowns.DischargeType, "Value", "Text");
            ViewBag.UrinationDifficultyType = new SelectList(Dropdowns.UrinationDifficulty, "Value", "Text");
            ViewBag.PainAbdomen = new SelectList(Dropdowns.PainAbdomen, "Value", "Text");
            ViewBag.Heent = new SelectList(Dropdowns.Heent, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text");
            ViewBag.Tender = new SelectList(Dropdowns.Tender, "Value", "Text");
            ViewBag.Mass = new SelectList(Dropdowns.Mass, "Value", "Text");
            ViewBag.MassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text");
            ViewBag.WoundDischarge = new SelectList(Dropdowns.WoundDischarge, "Value", "Text");
            ViewBag.Lungscondition = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");
            ViewBag.InfantCondition = new SelectList(Dropdowns.InfantCondition, "Value", "Text");
            return View();
        }

        // POST: PN/PostNatalMotherPhyExamination/Create
        [HttpPost]
        public ActionResult Create(PostNatal_MotherPhysicalExamination model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/PostNatalMotherPhyExamination/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
           
            ViewBag.DeliveryCondition = new SelectList(Dropdowns.DeliveryCondition, "Value", "Text",model.DeliveryCondition);
            ViewBag.DeliveryTerm = new SelectList(Dropdowns.DeliveryTerm, "Value", "Text",model.DeliveryTerm);
            ViewBag.DischargeType = new SelectList(Dropdowns.DischargeType, "Value", "Text",model.DischargeType);
            ViewBag.UrinationDifficultyType = new SelectList(Dropdowns.UrinationDifficulty, "Value", "Text",model.UrinationDifficultyType);
            ViewBag.PainAbdomen = new SelectList(Dropdowns.PainAbdomen, "Value", "Text",model.PainAbdomen);
            ViewBag.Heent = new SelectList(Dropdowns.Heent, "Value", "Text",model.Heent);
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text",model.Abdomen);
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text",model.HeartRate);
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text",model.HeartRythm);
            ViewBag.Tender = new SelectList(Dropdowns.Tender, "Value", "Text",model.Tender);
            ViewBag.Mass = new SelectList(Dropdowns.Mass, "Value", "Text",model.Mass);
            ViewBag.MassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text",model.MassQuality);
            ViewBag.WoundDischarge = new SelectList(Dropdowns.WoundDischarge, "Value", "Text",model.WoundDischarge);
            ViewBag.Lungscondition = new SelectList(Dropdowns.LungsRespiration, "Value", "Text",model.LungsCondition);
            ViewBag.InfantCondition = new SelectList(Dropdowns.InfantCondition, "Value", "Text",model.InfantCondition);
            return View(model);
        }

        // POST: PN/PostNatalMotherPhyExamination/Edit/5
        [HttpPost]
        public ActionResult Edit(PostNatal_MotherPhysicalExamination model)
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

        // POST: PN/PostNatalMotherPhyExamination/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }

        #region MotherPhysical Examination Tabwise
        [HttpGet]
        public ActionResult MotherCheckupTab()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.DeliveryCondition = new SelectList(Dropdowns.DeliveryCondition, "Value", "Text");
            ViewBag.DeliveryTerm = new SelectList(Dropdowns.DeliveryTerm, "Value", "Text");
            ViewBag.DischargeType = new SelectList(Dropdowns.DischargeType, "Value", "Text");
            ViewBag.UrinationDifficultyType = new SelectList(Dropdowns.UrinationDifficulty, "Value", "Text");
            ViewBag.PainAbdomen = new SelectList(Dropdowns.PainAbdomen, "Value", "Text");
            ViewBag.Heent = new SelectList(Dropdowns.Heent, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text");
            ViewBag.Tender = new SelectList(Dropdowns.Tender, "Value", "Text");
            ViewBag.Mass = new SelectList(Dropdowns.Mass, "Value", "Text");
            ViewBag.MassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text");
            ViewBag.WoundDischarge = new SelectList(Dropdowns.WoundDischarge, "Value", "Text");
            ViewBag.Lungscondition = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");
            ViewBag.InfantCondition = new SelectList(Dropdowns.InfantCondition, "Value", "Text");
            return View();
        }
        [HttpPost]
        public ActionResult MotherCheckupTab(PostNatal_MotherPhysicalExamination model)
        {
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("LabtestTab", "PostNatalMotherPhyExamination", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.DeliveryCondition = new SelectList(Dropdowns.DeliveryCondition, "Value", "Text");
            ViewBag.DeliveryTerm = new SelectList(Dropdowns.DeliveryTerm, "Value", "Text");
            ViewBag.DischargeType = new SelectList(Dropdowns.DischargeType, "Value", "Text");
            ViewBag.UrinationDifficultyType = new SelectList(Dropdowns.UrinationDifficulty, "Value", "Text");
            ViewBag.PainAbdomen = new SelectList(Dropdowns.PainAbdomen, "Value", "Text");
            ViewBag.Heent = new SelectList(Dropdowns.Heent, "Value", "Text");
            ViewBag.Abdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text");
            ViewBag.Tender = new SelectList(Dropdowns.Tender, "Value", "Text");
            ViewBag.Mass = new SelectList(Dropdowns.Mass, "Value", "Text");
            ViewBag.MassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text");
            ViewBag.WoundDischarge = new SelectList(Dropdowns.WoundDischarge, "Value", "Text");
            ViewBag.Lungscondition = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");
            ViewBag.InfantCondition = new SelectList(Dropdowns.InfantCondition, "Value", "Text");
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
                return RedirectToAction("AssessmentTab", "PostNatalMotherPhyExamination", new { area = "PN", PatientId = model.PatientId });
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
                return RedirectToAction("MedicationTab", "PostNatalMotherPhyExamination", new { area = "PN", PatientId = model.PatientId });
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
                return RedirectToAction("PlanTab", "PostNatalMotherPhyExamination", new { area = "PN", PatientId = model.PatientId });
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
                return RedirectToAction("MotherCheckupTab", "PostNatalMotherPhyExamination", new { area = "PN" });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
           
            return View(model);
        }
        #endregion
    }
}
