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
    public class InfantController : Controller
    {
        // GET: PN/Infant
        InfantBL obj = new InfantBL();
        OutParamModel outmodel = new OutParamModel();
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

      

        // GET: PN/Infant/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.DeliveryCondition = new SelectList(Dropdowns.DeliveryCondition, "Value", "Text");
            ViewBag.DeliveryTerm = new SelectList(Dropdowns.DeliveryTerm, "Value", "Text");
            ViewBag.Gender = new SelectList(Dropdowns.Genders, "Value", "Text");

            ViewBag.InfantCondition = new SelectList(Dropdowns.InfantCondition, "Value", "Text");
            ViewBag.FeedingCondition = new SelectList(Dropdowns.Feeding, "Value", "Text");

            ViewBag.Head = new SelectList(Dropdowns.Head, "Value", "Text");
            ViewBag.AntFontAnelle = new SelectList(Dropdowns.AntFontanelle, "Value", "Text");
            ViewBag.PostFontAnelle = new SelectList(Dropdowns.PostFontanelle, "Value", "Text");
            ViewBag.Sutures = new SelectList(Dropdowns.Satures, "Value", "Text");

            ViewBag.EyePupils = new SelectList(Dropdowns.EyePupil, "Value", "Text");
            ViewBag.EyeSclera = new SelectList(Dropdowns.EyeSclera, "Value", "Text");
            ViewBag.EyeConjuctiva = new SelectList(Dropdowns.Conjuctiva, "Value", "Text");
            ViewBag.EyeDischargeLeft = new SelectList(Dropdowns.EyeDischargeLeft, "Value", "Text");
            ViewBag.EyedischargeRight = new SelectList(Dropdowns.EyeDischargeRight, "Value", "Text");

            ViewBag.Neck = new SelectList(Dropdowns.Neck, "Value", "Text");
            ViewBag.NeckLeft = new SelectList(Dropdowns.NeckLeft, "Value", "Text");
            ViewBag.NeckRight = new SelectList(Dropdowns.NeckRight, "Value", "Text");
            ViewBag.SwollenLymphNode = new SelectList(Dropdowns.LymphNode, "Value", "Text");

            ViewBag.Suck = new SelectList(Dropdowns.Suck, "Value", "Text");
            ViewBag.Mouth = new SelectList(Dropdowns.Mouth, "Value", "Text");
            ViewBag.MouthGums = new SelectList(Dropdowns.MouthGums, "Value", "Text");
            ViewBag.Throat = new SelectList(Dropdowns.Throat, "Value", "Text");
            ViewBag.Nose = new SelectList(Dropdowns.Nose, "Value", "Text");
            ViewBag.NoseDischarge = new SelectList(Dropdowns.NoseDischarge, "Value", "Text");

            ViewBag.TMDischarge = new SelectList(Dropdowns.TMDischarge, "Value", "Text");
            ViewBag.EarPennaeLeft = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarPennaeRight = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarCanalLeft = new SelectList(Dropdowns.EarPene, "Value", "Text");
            ViewBag.EarCanalRight = new SelectList(Dropdowns.EarPene, "Value", "Text");

            ViewBag.LungRespiration = new SelectList(Dropdowns.LungsRespiration, "Value", "Text");
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text");
            ViewBag.HeartMurmur = new SelectList(Dropdowns.MurmurRate, "Value", "Text");
            ViewBag.HeartPedal = new SelectList(Dropdowns.HeartPedal, "Value", "Text");

            ViewBag.AbdAbdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text");
            ViewBag.AbdTender = new SelectList(Dropdowns.Tender, "Value", "Text");
            ViewBag.AbdMass = new SelectList(Dropdowns.Mass, "Value", "Text");
            ViewBag.AbdMassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text");
            ViewBag.AbdHernia = new SelectList(Dropdowns.Hernia, "Value", "Text");

            ViewBag.UmbClean = new SelectList(Dropdowns.UmbClean, "Value", "Text");
            ViewBag.UmbDischarge = new SelectList(Dropdowns.UmbDischarge, "Value", "Text");
            ViewBag.UmbHernia = new SelectList(Dropdowns.Hernia, "Value", "Text");

            ViewBag.GentTesties = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.GentHernia = new SelectList(Dropdowns.Hernia, "Value", "Text");
            ViewBag.GentPenis = new SelectList(Dropdowns.GentPenie, "Value", "Text");
            ViewBag.GentMeatus = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.GentDischargeMale = new SelectList(Dropdowns.GentDischarge, "Value", "Text");
            ViewBag.GentNormal = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text");
            ViewBag.GentLabia = new SelectList(Dropdowns.GentLabia, "Value", "Text");
            ViewBag.GentUrethra = new SelectList(Dropdowns.GentUrethra, "Value", "Text");
            ViewBag.GentDishargeFemale = new SelectList(Dropdowns.GentDischargeFemale, "Value", "Text");
            ViewBag.GentMass = new SelectList(Dropdowns.GentMass, "Value", "Text");

            ViewBag.MuscArms = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.MuscWeekness = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.MuscSwelling = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.MuscTender = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.MuscImmobile = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.MuscDecStrength = new SelectList(Dropdowns.LeftRight, "Value", "Text");

            ViewBag.HandSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.HandWeekness = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.HandSwelling = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.HandTender = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.HandImmobile = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.HandDecStrength = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.HandFingers = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.HandBruise = new SelectList(Dropdowns.LeftRight, "Value", "Text");

            ViewBag.LegSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.LegWeekness = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.LegFlacid = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.LegNomalTone = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.LegSwelling = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.LegTender = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.LegImmobile = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.LegDecStrength = new SelectList(Dropdowns.LeftRight, "Value", "Text");

            ViewBag.FeetSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.FeetWeekness = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.FeetSwelling = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.FeetTender = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.FeetImmobile = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.FeetDecStrength = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.FeetClubFoot = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.FeetToes = new SelectList(Dropdowns.LeftRight, "Value", "Text");
            ViewBag.HipSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text");
            ViewBag.HipLeft = new SelectList(Dropdowns.Hip, "Value", "Text");
            ViewBag.HipRight = new SelectList(Dropdowns.Hip, "Value", "Text");
            ViewBag.SkinNormal = new SelectList(Dropdowns.Skin, "Value", "Text");

            ViewBag.BloodGroup = new SelectList(Dropdowns.BloodGroup, "Value", "Text");
            ViewBag.Protein = new SelectList(Dropdowns.Protien, "Value", "Text");
            ViewBag.Glucose = new SelectList(Dropdowns.Glucose, "Value", "Text");
            ViewBag.WBC = new SelectList(Dropdowns.WBC, "Value", "Text");
            ViewBag.Keytone = new SelectList(Dropdowns.Keytone, "Value", "Text");
            ViewBag.Blood = new SelectList(Dropdowns.Blood, "Value", "Text");
            return View();
        }

        // POST: PN/Infant/Create
        [HttpPost]
        public ActionResult Create(PostNatal_Infant model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/Infant/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text",model.PatientId);
            ViewBag.DeliveryCondition = new SelectList(Dropdowns.DeliveryCondition, "Value", "Text",model.DeliveryCondition);
            ViewBag.DeliveryTerm = new SelectList(Dropdowns.DeliveryTerm, "Value", "Text",model.DeliveryTerm);
            ViewBag.InfantCondition = new SelectList(Dropdowns.InfantCondition, "Value", "Text",model.InfantCondition);
            ViewBag.FeedingCondition = new SelectList(Dropdowns.Feeding, "Value", "Text",model.FeedingCondition);
            ViewBag.Gender = new SelectList(Dropdowns.Genders, "Value", "Text",model.Gender);

            ViewBag.Head = new SelectList(Dropdowns.Head, "Value", "Text",model.Head);
            ViewBag.AntFontAnelle = new SelectList(Dropdowns.AntFontanelle, "Value", "Text",model.AntFontAnelle);
            ViewBag.PostFontAnelle = new SelectList(Dropdowns.PostFontanelle, "Value", "Text",model.PostFontAnelle);
            ViewBag.Sutures = new SelectList(Dropdowns.Satures, "Value", "Text",model.Sutures);

            ViewBag.EyePupils = new SelectList(Dropdowns.EyePupil, "Value", "Text",model.EyePupils);
            ViewBag.EyeSclera = new SelectList(Dropdowns.EyeSclera, "Value", "Text",model.EyeSclera);
            ViewBag.EyeConjuctiva = new SelectList(Dropdowns.Conjuctiva, "Value", "Text",model.EyeConjuctiva);
            ViewBag.EyeDischargeLeft = new SelectList(Dropdowns.EyeDischargeLeft, "Value", "Text",model.EyeDischargeLeft);
            ViewBag.EyedischargeRight = new SelectList(Dropdowns.EyeDischargeRight, "Value", "Text",model.EyeDischargeRight);

            ViewBag.Neck = new SelectList(Dropdowns.Neck, "Value", "Text",model.Neck);
            ViewBag.NeckLeft = new SelectList(Dropdowns.NeckLeft, "Value", "Text",model.NeckLeft);
            ViewBag.NeckRight = new SelectList(Dropdowns.NeckRight, "Value", "Text",model.NeckRight);
            ViewBag.SwollenLymphNode = new SelectList(Dropdowns.LymphNode, "Value", "Text",model.SwollenLymphNode);

            ViewBag.Suck = new SelectList(Dropdowns.Suck, "Value", "Text",model.Suck);
            ViewBag.Mouth = new SelectList(Dropdowns.Mouth, "Value", "Text",model.Mouth);
            ViewBag.MouthGums = new SelectList(Dropdowns.MouthGums, "Value", "Text",model.MouthGums);
            ViewBag.Throat = new SelectList(Dropdowns.Throat, "Value", "Text",model.Throat);
            ViewBag.Nose = new SelectList(Dropdowns.Nose, "Value", "Text",model.Nose);
            ViewBag.NoseDischarge = new SelectList(Dropdowns.NoseDischarge, "Value", "Text",model.NoseDischarge);

            ViewBag.TMDischarge = new SelectList(Dropdowns.TMDischarge, "Value", "Text",model.TMDischarge);
            ViewBag.EarPennaeLeft = new SelectList(Dropdowns.EarPene, "Value", "Text",model.EarPennaeLeft);
            ViewBag.EarPennaeRight = new SelectList(Dropdowns.EarPene, "Value", "Text",model.EarPennaeRight);
            ViewBag.EarCanalLeft = new SelectList(Dropdowns.EarPene, "Value", "Text",model.EarCanalLeft);
            ViewBag.EarCanalRight = new SelectList(Dropdowns.EarPene, "Value", "Text",model.EarCanalRight);

            ViewBag.LungRespiration = new SelectList(Dropdowns.LungsRespiration, "Value", "Text",model.LungRespiration);
            ViewBag.HeartRate = new SelectList(Dropdowns.HeartRate, "Value", "Text",model.HeartRate);
            ViewBag.HeartMurmur = new SelectList(Dropdowns.MurmurRate, "Value", "Text",model.HeartMurmur);
            ViewBag.HeartPedal = new SelectList(Dropdowns.HeartPedal, "Value", "Text",model.HeartPedal);

            ViewBag.AbdAbdomen = new SelectList(Dropdowns.Abdomen, "Value", "Text",model.AbdAbdomen);
            ViewBag.AbdTender = new SelectList(Dropdowns.Tender, "Value", "Text",model.AbdTender);
            ViewBag.AbdMass = new SelectList(Dropdowns.Mass, "Value", "Text",model.AbdMass);
            ViewBag.AbdMassQuality = new SelectList(Dropdowns.MassQuality, "Value", "Text",model.AbdMassQuality);
            ViewBag.AbdHernia = new SelectList(Dropdowns.Hernia, "Value", "Text",model.AbdHernia);

            ViewBag.UmbClean = new SelectList(Dropdowns.UmbClean, "Value", "Text",model.UmbClean);
            ViewBag.UmbDischarge = new SelectList(Dropdowns.UmbDischarge, "Value", "Text",model.UmbDischarge);
            ViewBag.UmbHernia = new SelectList(Dropdowns.Hernia, "Value", "Text",model.UmbHernia);

            ViewBag.GentTesties = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.GentTesties);
            ViewBag.GentHernia = new SelectList(Dropdowns.Hernia, "Value", "Text",model.GentHernia);
            ViewBag.GentPenis = new SelectList(Dropdowns.GentPenie, "Value", "Text",model.GentPenis);
            ViewBag.GentMeatus = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.GentMeatus);
            ViewBag.GentDischargeMale = new SelectList(Dropdowns.GentDischarge, "Value", "Text",model.GentDischargeMale);
            ViewBag.GentNormal = new SelectList(Dropdowns.NormalAbnormal, "Value", "Text",model.GentNormal);
            ViewBag.GentLabia = new SelectList(Dropdowns.GentLabia, "Value", "Text",model.GentLabia);
            ViewBag.GentUrethra = new SelectList(Dropdowns.GentUrethra, "Value", "Text",model.GentUrethra);
            ViewBag.GentDishargeFemale = new SelectList(Dropdowns.GentDischargeFemale, "Value", "Text",model.GentDishargeFemale);
            ViewBag.GentMass = new SelectList(Dropdowns.GentMass, "Value", "Text",model.GentMass);

            ViewBag.MuscArms = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text",model.MuscArms);
            ViewBag.MuscWeekness = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.MuscWeekness);
            ViewBag.MuscSwelling = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.MuscSwelling);
            ViewBag.MuscTender = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.MuscTender);
            ViewBag.MuscImmobile = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.MuscImmobile);
            ViewBag.MuscDecStrength = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.MuscDecStrength);

            ViewBag.HandSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text",model.HandSymmetry);
            ViewBag.HandWeekness = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.HandWeekness);
            ViewBag.HandSwelling = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.HandSwelling);
            ViewBag.HandTender = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.HandTender);
            ViewBag.HandImmobile = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.HandImmobile);
            ViewBag.HandDecStrength = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.HandDecStrength);
            ViewBag.HandFingers = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.HandFingers);
            ViewBag.HandBruise = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.HandBruise);

            ViewBag.LegSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text",model.LegSymmetry);
            ViewBag.LegWeekness = new SelectList(Dropdowns.LeftRight, "Value", "Text" ,model.LegWeekness);
            ViewBag.LegFlacid = new SelectList(Dropdowns.LeftRight, "Value", "Text"   ,model.LegFlacid);
            ViewBag.LegNomalTone = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.LegNomalTone);
            ViewBag.LegSwelling = new SelectList(Dropdowns.LeftRight, "Value", "Text" ,model.LegSwelling);
            ViewBag.LegTender = new SelectList(Dropdowns.LeftRight, "Value", "Text"   ,model.LegTender);
            ViewBag.LegImmobile = new SelectList(Dropdowns.LeftRight, "Value", "Text" ,model.LegImmobile);
            ViewBag.LegDecStrength = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.LegDecStrength);

            ViewBag.FeetSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text",model.FeetSymmetry);
            ViewBag.FeetWeekness = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.FeetWeekness);
            ViewBag.FeetSwelling = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.FeetSwelling);
            ViewBag.FeetTender = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.FeetTender);
            ViewBag.FeetImmobile = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.FeetImmobile);
            ViewBag.FeetDecStrength = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.FeetDecStrength);
            ViewBag.FeetClubFoot = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.FeetClubFoot);
            ViewBag.FeetToes = new SelectList(Dropdowns.LeftRight, "Value", "Text",model.FeetToes);
            ViewBag.HipSymmetry = new SelectList(Dropdowns.MuscSymmetry, "Value", "Text",model.HipSymmetry);
            ViewBag.HipLeft = new SelectList(Dropdowns.Hip, "Value", "Text",model.HipLeft);
            ViewBag.HipRight = new SelectList(Dropdowns.Hip, "Value", "Text",model.HipRight);
            ViewBag.SkinNormal = new SelectList(Dropdowns.Skin, "Value", "Text",model.SkinNormal);

            ViewBag.BloodGroup = new SelectList(Dropdowns.BloodGroup, "Value", "Text",model.BloodGroup);
            ViewBag.Protein = new SelectList(Dropdowns.Protien, "Value", "Text",model.Protein);
            ViewBag.Glucose = new SelectList(Dropdowns.Glucose, "Value", "Text",model.Glucose);
            ViewBag.WBC = new SelectList(Dropdowns.WBC, "Value", "Text",model.WBC);
            ViewBag.Keytone = new SelectList(Dropdowns.Keytone, "Value", "Text",model.Keytone);
            ViewBag.Blood = new SelectList(Dropdowns.Blood, "Value", "Text",model.Blood);
            return View(model);
        }

        // POST: PN/Infant/Edit/5
        [HttpPost]
        public ActionResult Edit(PostNatal_Infant model)
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

        // POST: PN/Infant/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
    }
}
