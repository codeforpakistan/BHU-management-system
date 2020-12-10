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
    public class UltrasoundController : Controller
    {
        // GET: PN/Ultrasound
        UltrasoundBL obj = new UltrasoundBL();
        OutParamModel outmodel = new OutParamModel();
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }


        // GET: PN/Ultrasound/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            ViewBag.Placenta = new SelectList(Dropdowns.Placenta, "Value", "Text");
            ViewBag.Grade = new SelectList(Dropdowns.Grade, "Value", "Text");
            ViewBag.Cord = new SelectList(Dropdowns.Cord, "Value", "Text");
            ViewBag.AmnioticFluidVolume = new SelectList(Dropdowns.AmnioticFluidVolume, "Value", "Text");
            ViewBag.Gender = new SelectList(Dropdowns.Genders, "Value", "Text");
            ViewBag.NoOfFetuses = new SelectList(Dropdowns.NoOfFetuses, "Value", "Text");
            ViewBag.Position = new SelectList(Dropdowns.Position, "Value", "Text");
            ViewBag.Face = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.Brain = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.Spine = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.Lungs = new SelectList(Dropdowns.LungsU, "Value", "Text");
            ViewBag.HeartCondition = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.Stomach = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.CordInsertion = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.ExtLeftArms = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.ExtRightArms = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.ExtLeftLegs = new SelectList(Dropdowns.FBS, "Value", "Text");
            ViewBag.ExtRightLegs = new SelectList(Dropdowns.FBS, "Value", "Text");
            return View();
        }

        // POST: PN/Ultrasound/Create
        [HttpPost]
        public ActionResult Create(Ultrasound model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/Ultrasound/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            ViewBag.Placenta = new SelectList(Dropdowns.Placenta, "Value", "Text",model.Placenta);
            ViewBag.Grade = new SelectList(Dropdowns.Grade, "Value", "Text",model.Grade);
            ViewBag.Cord = new SelectList(Dropdowns.Cord, "Value", "Text",model.Cord);
            ViewBag.AmnioticFluidVolume = new SelectList(Dropdowns.AmnioticFluidVolume, "Value", "Text",model.AmnioticFluidVolume);
            ViewBag.Gender = new SelectList(Dropdowns.Genders, "Value", "Text",model.Gender);
            ViewBag.NoOfFetuses = new SelectList(Dropdowns.NoOfFetuses, "Value", "Text",model.NoOfFetuses);
            ViewBag.Position = new SelectList(Dropdowns.Position, "Value", "Text",model.Position);
            ViewBag.Face = new SelectList(Dropdowns.FBS, "Value", "Text",model.Face);
            ViewBag.Brain = new SelectList(Dropdowns.FBS, "Value", "Text",model.Brain);
            ViewBag.Spine = new SelectList(Dropdowns.FBS, "Value", "Text",model.Spine);
            ViewBag.Lungs = new SelectList(Dropdowns.LungsU, "Value", "Text",model.Lungs);
            ViewBag.HeartCondition = new SelectList(Dropdowns.FBS, "Value", "Text",model.HeartCondition);
            ViewBag.Stomach = new SelectList(Dropdowns.FBS, "Value", "Text",model.Stomach);
            ViewBag.CordInsertion = new SelectList(Dropdowns.FBS, "Value", "Text",model.CordInsertion);
            ViewBag.ExtLeftArms = new SelectList(Dropdowns.FBS, "Value", "Text",model.ExtLeftArms);
            ViewBag.ExtRightArms = new SelectList(Dropdowns.FBS, "Value", "Text",model.ExtRightArms);
            ViewBag.ExtLeftLegs = new SelectList(Dropdowns.FBS, "Value", "Text",model.ExtLeftLegs);
            ViewBag.ExtRightLegs = new SelectList(Dropdowns.FBS, "Value", "Text",model.ExtRightLegs);
            return View(model);
        }

        // POST: PN/Ultrasound/Edit/5
        [HttpPost]
        public ActionResult Edit(Ultrasound model)
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


        // POST: PN/Ultrasound/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
    }
}
