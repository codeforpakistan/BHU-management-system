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
    public class PaedsPhyExaminationController : Controller
    {
        PaedsPhysicalExamBL obj = new PaedsPhysicalExamBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/PaedsPhyExamination
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }


        // GET: PN/PaedsPhyExamination/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.Head = new SelectList(Dropdowns.Head, "Value", "Text");
            ViewBag.AntFontAnelle = new SelectList(Dropdowns.AntFontanelle, "Value", "Text");
            ViewBag.PostFontAnelle = new SelectList(Dropdowns.PostFontanelle, "Value", "Text");
            ViewBag.Sutures = new SelectList(Dropdowns.Satures, "Value", "Text");

            ViewBag.EyePupils = new SelectList(Dropdowns.EyePupil, "Value", "Text");
            ViewBag.EyeSclera = new SelectList(Dropdowns.EyeSclera, "Value", "Text");
            ViewBag.EyeConjuctiva = new SelectList(Dropdowns.Conjuctiva, "Value", "Text");
            ViewBag.EyeDischargeLeft = new SelectList(Dropdowns.EyeDischargeLeft, "Value", "Text");
            ViewBag.EyeDischargeRight = new SelectList(Dropdowns.EyeDischargeRight, "Value", "Text");

            ViewBag.EarPennaeLeft = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarPennaeRight = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarCanalLeft = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarCanalRight = new SelectList(Dropdowns.EarPene, "Value", "Text");
           

            ViewBag.Mouth = new SelectList(Dropdowns.Mouth, "Value", "Text");
            ViewBag.Throat = new SelectList(Dropdowns.Throat, "Value", "Text");
            ViewBag.Tonsils = new SelectList(Dropdowns.Tonsils, "Value", "Text");
            ViewBag.Nose = new SelectList(Dropdowns.Nose, "Value", "Text");
            ViewBag.NoseDischarge = new SelectList(Dropdowns.NoseDischarge, "Value", "Text");

            ViewBag.Neck = new SelectList(Dropdowns.Neck, "Value", "Text");
            ViewBag.NeckLeft = new SelectList(Dropdowns.NeckLeft, "Value", "Text");
            ViewBag.NeckRight = new SelectList(Dropdowns.NeckRight, "Value", "Text");
            ViewBag.SwollenLymphNode = new SelectList(Dropdowns.LymphNode, "Value", "Text");
            ViewBag.LungsRespiration = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");

            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text");
            ViewBag.MurmurRate = new SelectList(Dropdowns.MurmurRate, "Value", "Text");
            ViewBag.TMDischarge = new SelectList(Dropdowns.TMDischarge, "Value", "Text");

            ViewBag.AbdAbdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.AbdTender = new SelectList(Dropdowns.Tender, "Value", "Text");
            //ViewBag.AbdMass = new SelectList(Dropdowns.Mass, "Value", "Text");
            ViewBag.AbdMassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text");
            ViewBag.AbdUmbilicalHernia = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.AbdInguinalHernialLeft = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.AbdInguinalHernialRight = new SelectList(Dropdowns.Hernia, "Value", "Text");

            ViewBag.GentMale = new SelectList(Dropdowns.GentMale, "Value", "Text");
            ViewBag.GentHerniaLeft = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.GentHerniaRight = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.GentPenis = new SelectList(Dropdowns.GentPenie, "Value", "Text");
            ViewBag.GentMeatus = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.GentDishcharge = new SelectList(Dropdowns.GentDischarge, "Value", "Text");
            ViewBag.GentFemale = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.GentLabia = new SelectList(Dropdowns.GentLabia, "Value", "Text");
            ViewBag.GentUrethra = new SelectList(Dropdowns.GentUrethra, "Value", "Text");
            ViewBag.GentDischarge = new SelectList(Dropdowns.GentDischargeFemale, "Value", "Text");
            ViewBag.GentMassLeft = new SelectList(Dropdowns.GentMass, "Value", "Text");
            ViewBag.GentMassRight = new SelectList(Dropdowns.GentMass, "Value", "Text");

            ViewBag.NeuroReflexLeft = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.NeuroReflexRight = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.NeuroDevelopment = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");

            ViewBag.UmbClean = new SelectList(Dropdowns.UmbClean, "Value", "Text");
            ViewBag.UmdDishcharge = new SelectList(Dropdowns.UmbDischarge, "Value", "Text");

            ViewBag.MuscArmsLegs = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.FeetHandSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.FeetToes = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");

            ViewBag.Skin = new SelectList(Dropdowns.Skin, "Value", "Text");
            return View();
        }

        // POST: PN/PaedsPhyExamination/Create
        [HttpPost]
        public ActionResult Create(Paeds_PhysicalExamination model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/PaedsPhyExamination/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.Head = new SelectList(Dropdowns.Head, "Value", "Text", model.Head);
            ViewBag.AntFontAnelle = new SelectList(Dropdowns.AntFontanelle, "Value", "Text", model.AntFontAnelle);
            ViewBag.PostFontAnelle = new SelectList(Dropdowns.PostFontanelle, "Value", "Text", model.PostFontAnelle);
            ViewBag.Sutures = new SelectList(Dropdowns.Satures, "Value", "Text", model.Sutures);

            ViewBag.EyePupils = new SelectList(Dropdowns.EyePupil, "Value", "Text", model.EyePupils);
            ViewBag.EyeSclera = new SelectList(Dropdowns.EyeSclera, "Value", "Text", model.EyeSclera);
            ViewBag.EyeConjuctiva = new SelectList(Dropdowns.Conjuctiva, "Value", "Text", model.EyeConjuctiva);
            ViewBag.EyeDischargeLeft = new SelectList(Dropdowns.EyeDischargeLeft, "Value", "Text", model.EyeDischargeLeft);
            ViewBag.EyeDischargeRight = new SelectList(Dropdowns.EyeDischargeRight, "Value", "Text", model.EyeDischargeRight);

            ViewBag.EarPennaeLeft = new SelectList(Dropdowns.EarPene, "Value", "Text", model.EarPennaeLeft);
            ViewBag.EarPennaeRight = new SelectList(Dropdowns.EarPene, "Value", "Text", model.EarPennaeRight);
            ViewBag.EarCanalLeft = new SelectList(Dropdowns.EarPene, "Value", "Text", model.EarCanalLeft);
            ViewBag.EarCanalRight = new SelectList(Dropdowns.EarPene, "Value", "Text", model.EarCanalRight);
            

            ViewBag.Mouth = new SelectList(Dropdowns.Mouth, "Value", "Text", model.Mouth);
            ViewBag.Throat = new SelectList(Dropdowns.Throat, "Value", "Text", model.Throat);
            ViewBag.Tonsils = new SelectList(Dropdowns.Tonsils, "Value", "Text", model.Tonsils);
            ViewBag.Nose = new SelectList(Dropdowns.Nose, "Value", "Text", model.Nose);
            ViewBag.NoseDischarge = new SelectList(Dropdowns.NoseDischarge, "Value", "Text", model.NoseDischarge);

            ViewBag.Neck = new SelectList(Dropdowns.Neck, "Value", "Text", model.Neck);
            ViewBag.NeckLeft = new SelectList(Dropdowns.NeckLeft, "Value", "Text", model.NeckLeft);
            ViewBag.NeckRight = new SelectList(Dropdowns.NeckRight, "Value", "Text", model.NeckRight);
            ViewBag.SwollenLymphNode = new SelectList(Dropdowns.LymphNode, "Value", "Text", model.SwollenLymphNode);
            ViewBag.LungsRespiration = new SelectList(Dropdowns.LungsRespiration, "Value", "Text", model.LungsRespiration);

            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text", model.HeartRate);
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text", model.HeartRythm);
            ViewBag.MurmurRate = new SelectList(Dropdowns.MurmurRate, "Value", "Text", model.MurmurRate);
            ViewBag.TMDischarge = new SelectList(Dropdowns.TMDischarge, "Value", "Text",model.TMDischarge);

            ViewBag.AbdAbdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text",model.AbdAbdomen);
            ViewBag.AbdTender = new SelectList(Dropdowns.Tender, "Value", "Text",model.AbdTender);
            //ViewBag.AbdMass = new SelectList(Dropdowns.Mass, "Value", "Text",model.AbdMass);
            ViewBag.AbdMassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text",model.AbdMassQuality);
            ViewBag.AbdUmbilicalHernia = new SelectList(Dropdowns.Hernia, "Value", "Text",model.AbdUmbilicalHernia);
            ViewBag.AbdInguinalHernialLeft = new SelectList(Dropdowns.Hernia, "Value", "Text",model.AbdInguinalHernialLeft);
            ViewBag.AbdInguinalHernialRight = new SelectList(Dropdowns.Hernia, "Value", "Text",model.AbdInguinalHernialRight);

            ViewBag.GentMale = new SelectList(Dropdowns.GentMale, "Value", "Text",model.GentMale);
            ViewBag.GentHerniaLeft = new SelectList(Dropdowns.Hernia, "Value", "Text",model.GentHerniaLeft);
            ViewBag.GentHerniaRight = new SelectList(Dropdowns.Hernia, "Value", "Text",model.GentHerniaRight);
            ViewBag.GentPenis = new SelectList(Dropdowns.GentPenie, "Value", "Text",model.GentPenis);
            ViewBag.GentMeatus = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.GentMeatus);
            ViewBag.GentDishcharge = new SelectList(Dropdowns.GentDischarge, "Value", "Text",model.GentDishcharge);
            ViewBag.GentFemale = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.GentFemale);
            ViewBag.GentLabia = new SelectList(Dropdowns.GentLabia, "Value", "Text",model.GentLabia);
            ViewBag.GentUrethra = new SelectList(Dropdowns.GentUrethra, "Value", "Text",model.GentUrethra);
            ViewBag.GentDischarge = new SelectList(Dropdowns.GentDischargeFemale, "Value", "Text",model.GentDischarge);
            ViewBag.GentMassLeft = new SelectList(Dropdowns.GentMass, "Value", "Text",model.GentMassLeft);
            ViewBag.GentMassRight = new SelectList(Dropdowns.GentMass, "Value", "Text",model.GentMassRight);

            ViewBag.NeuroReflexLeft = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.NeuroReflexLeft);
            ViewBag.NeuroReflexRight = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.NeuroReflexRight);
            ViewBag.NeuroDevelopment = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.NeuroDevelopment);

            ViewBag.UmbClean = new SelectList(Dropdowns.UmbClean, "Value", "Text",model.UmbClean);
            ViewBag.UmdDishcharge = new SelectList(Dropdowns.UmbDischarge, "Value", "Text",model.UmdDishcharge);

            ViewBag.MuscArmsLegs = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text",model.MuscArmsLegs);
            ViewBag.FeetHandSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text",model.FeetHandSymmetry);
            ViewBag.FeetToes = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.FeetToes);

            ViewBag.Skin = new SelectList(Dropdowns.Skin, "Value", "Text",model.Skin);
            return View(model);
        }

        // POST: PN/PaedsPhyExamination/Edit/5
        [HttpPost]
        public ActionResult Edit(Paeds_PhysicalExamination model)
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
            catch (Exception ex)
            {
                ex.Message.ToString();
                return View();
            }
        }


        // POST: PN/PaedsPhyExamination/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }

        #region Tabs
        [HttpGet]
        public ActionResult GeneralTab()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            return View();
        }
        [HttpPost]
        public ActionResult GeneralTab(PaedsForm model)
        {
            PaedsBL obj = new PaedsBL();
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("PaedsPhysicalTab", "PaedsPhyExamination", new { area = "PN", PatientId = model.PatientId });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            return View();
        }
        [HttpGet]
        public ActionResult PaedsPhysicalTab(int PatientId)
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", PatientId);
            ViewBag.Head = new SelectList(Dropdowns.Head, "Value", "Text");
            ViewBag.AntFontAnelle = new SelectList(Dropdowns.AntFontanelle, "Value", "Text");
            ViewBag.PostFontAnelle = new SelectList(Dropdowns.PostFontanelle, "Value", "Text");
            ViewBag.Sutures = new SelectList(Dropdowns.Satures, "Value", "Text");

            ViewBag.EyePupils = new SelectList(Dropdowns.EyePupil, "Value", "Text");
            ViewBag.EyeSclera = new SelectList(Dropdowns.EyeSclera, "Value", "Text");
            ViewBag.EyeConjuctiva = new SelectList(Dropdowns.Conjuctiva, "Value", "Text");
            ViewBag.EyeDischargeLeft = new SelectList(Dropdowns.EyeDischargeLeft, "Value", "Text");
            ViewBag.EyeDischargeRight = new SelectList(Dropdowns.EyeDischargeRight, "Value", "Text");

            ViewBag.EarPennaeLeft = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarPennaeRight = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarCanalLeft = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarCanalRight = new SelectList(Dropdowns.EarPene, "Value", "Text");


            ViewBag.Mouth = new SelectList(Dropdowns.Mouth, "Value", "Text");
            ViewBag.Throat = new SelectList(Dropdowns.Throat, "Value", "Text");
            ViewBag.Tonsils = new SelectList(Dropdowns.Tonsils, "Value", "Text");
            ViewBag.Nose = new SelectList(Dropdowns.Nose, "Value", "Text");
            ViewBag.NoseDischarge = new SelectList(Dropdowns.NoseDischarge, "Value", "Text");

            ViewBag.Neck = new SelectList(Dropdowns.Neck, "Value", "Text");
            ViewBag.NeckLeft = new SelectList(Dropdowns.NeckLeft, "Value", "Text");
            ViewBag.NeckRight = new SelectList(Dropdowns.NeckRight, "Value", "Text");
            ViewBag.SwollenLymphNode = new SelectList(Dropdowns.LymphNode, "Value", "Text");
            ViewBag.LungsRespiration = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");

            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartRythm = new SelectList(Dropdowns.HeartRythm, "Value", "Text");
            ViewBag.MurmurRate = new SelectList(Dropdowns.MurmurRate, "Value", "Text");
            ViewBag.TMDischarge = new SelectList(Dropdowns.TMDischarge, "Value", "Text");

            ViewBag.AbdAbdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.AbdTender = new SelectList(Dropdowns.Tender, "Value", "Text");
            //ViewBag.AbdMass = new SelectList(Dropdowns.Mass, "Value", "Text");
            ViewBag.AbdMassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text");
            ViewBag.AbdUmbilicalHernia = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.AbdInguinalHernialLeft = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.AbdInguinalHernialRight = new SelectList(Dropdowns.Hernia, "Value", "Text");

            ViewBag.GentMale = new SelectList(Dropdowns.GentMale, "Value", "Text");
            ViewBag.GentHerniaLeft = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.GentHerniaRight = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.GentPenis = new SelectList(Dropdowns.GentPenie, "Value", "Text");
            ViewBag.GentMeatus = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.GentDishcharge = new SelectList(Dropdowns.GentDischarge, "Value", "Text");
            ViewBag.GentFemale = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.GentLabia = new SelectList(Dropdowns.GentLabia, "Value", "Text");
            ViewBag.GentUrethra = new SelectList(Dropdowns.GentUrethra, "Value", "Text");
            ViewBag.GentDischarge = new SelectList(Dropdowns.GentDischargeFemale, "Value", "Text");
            ViewBag.GentMassLeft = new SelectList(Dropdowns.GentMass, "Value", "Text");
            ViewBag.GentMassRight = new SelectList(Dropdowns.GentMass, "Value", "Text");

            ViewBag.NeuroReflexLeft = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.NeuroReflexRight = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.NeuroDevelopment = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");

            ViewBag.UmbClean = new SelectList(Dropdowns.UmbClean, "Value", "Text");
            ViewBag.UmdDishcharge = new SelectList(Dropdowns.UmbDischarge, "Value", "Text");

            ViewBag.MuscArmsLegs = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.FeetHandSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.FeetToes = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");

            ViewBag.Skin = new SelectList(Dropdowns.Skin, "Value", "Text");
            return View();
        }
        [HttpPost]
        public ActionResult PaedsPhysicalTab(Paeds_PhysicalExamination model)
        {
            if (ModelState.IsValid)
            {
                var toReturn = obj.Save(model, out outmodel);
                return RedirectToAction("LabtestTab", "PaedsPhyExamination", new { area = "PN", PatientId = model.PatientId });
            }
         
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
                return RedirectToAction("AssessmentTab", "PaedsPhyExamination", new { area = "PN", PatientId = model.PatientId });
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
                return RedirectToAction("MedicationTab", "PaedsPhyExamination", new { area = "PN", PatientId = model.PatientId });
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
                return RedirectToAction("PlanTab", "PaedsPhyExamination", new { area = "PN", PatientId = model.PatientId });
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
                return RedirectToAction("GeneralTab", "PaedsPhyExamination", new { area = "PN" });
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");

            return View(model);
        }
        #endregion
    }
}
